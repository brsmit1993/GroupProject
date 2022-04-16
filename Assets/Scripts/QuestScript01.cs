using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class QuestScript01 : MonoBehaviour
{
    public GameObject questText;
    public GameObject inspectMarker;
    public GameObject buildMarker;
    public GameObject scoreKeeper;

    //Moves this GameObject 2 units a second in the forward direction
    void Update()
    {
    }

    private void Start()
    {
       
    }
    //Upon collision with another GameObject, this GameObject will reverse direction
    private void OnTriggerEnter(Collider other)
    {
        scoreKeeper.GetComponent<ScoreKeeperScript>().startTime = Time.time;
        questText.GetComponent<TextMeshPro>().text = "Test Actived/nGood Luck!!!";
        inspectMarker.SetActive(true);
        buildMarker.SetActive(true);
        Destroy(this.transform.parent.gameObject);
    }
}
