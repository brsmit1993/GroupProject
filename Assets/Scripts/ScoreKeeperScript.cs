using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreKeeperScript : MonoBehaviour
{
    public float startTime;
    public float completeTime;
    public float currentTime;

    public const float possibleTotal = 4100f; // total possible is actually 4200 but we give 100pt buffer so people can get 100%
    public const float timeLimit = 600f;
    public const float firstTryPointValue = 100f;
    public const float correctPlacementPointValue = 50f;
    public const float incorrectGuessPointValue = 25f;

    public float totalPoints = 0f;
    public float timeBonus = 0f;
    public float accuracyBonus = 0f;
    public float firstTryBonus = 0f;
    public float correctPlacementBonus = 0f;
    public float incorrectGuessPenalty = 0f;

    public GameObject ScoreCanvas;
    public TextMeshProUGUI bonusText;
    public TextMeshProUGUI infoText;
    public TextMeshProUGUI finalPoitText;
    public TextMeshProUGUI finalPrctText;
    public GameObject playerObject;
    public float StartTime { get => startTime; set => startTime = value; }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime = Time.time;
    }

    public void correctComponentPicked(int attempt)
    {
        if(attempt == 0)
        {
            firstTryBonus = firstTryBonus + firstTryPointValue;
        }
        correctPlacementBonus = correctPlacementBonus + 50;
    }

    public void wrongComponentPicked()
    {
        incorrectGuessPenalty = incorrectGuessPenalty - incorrectGuessPointValue;
    }

    public void completedBuild(float corGuesses, float totalGuesses)
    {
        completeTime = Time.time;
        if(completeTime-startTime < timeLimit)
        {
            timeBonus = 500 * ((timeLimit - (completeTime - startTime)) / 600);
        }
        else
        {
            timeBonus = 0f;
        }

        accuracyBonus = (corGuesses / totalGuesses) * 1000;

        totalPoints = timeBonus + accuracyBonus + firstTryBonus + correctPlacementBonus + incorrectGuessPenalty;

        ScoreCanvas.SetActive(true);
        bonusText.text = "<b>Point Break Down\n----------------------------</b>\nTime\n"+timeBonus+"\nAccuracy\n" + accuracyBonus + "\nFirst Try \n"+ firstTryBonus + "\nCorrect Placement\n"+correctPlacementBonus+"\nIncorrect Placement\n" + incorrectGuessPenalty;
        infoText.text = "<b>Additional Info</b>\n-----------------------------------\nTime Taken\n"+(completeTime-startTime)+"\nCorrect Guesses\n"+corGuesses+"\nIncorrect Guesses\n"+(totalGuesses - corGuesses)+"\nTotal Guesses\n"+totalGuesses+"\nAccuracy Perc.\n" + (int) System.Math.Round(corGuesses/totalGuesses * 100) +"%";
        finalPoitText.text = "<b>Final Score Pts\n----------------------------</b>\n"+ (int)System.Math.Round(totalPoints) + "/4100";
        finalPrctText.text = "<b>Final Score Pts\n----------------------------</b>\n" + (int) System.Math.Round(totalPoints/ possibleTotal * 100)+"%";
        
        Destroy(playerObject);
    }
}
