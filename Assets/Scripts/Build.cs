using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System;


    public class Build : MonoBehaviour
    {
        // Start is called before the first frame update
        private string[] expectedObject = { "ComputerCase", "Fan", "Fan", "Fan", "Fan", "MotherBoard", "CPU", "Ram", "Ram", "Ram", "Ram", "GPU", "GPU", "CoolingSystem", "HardDrive", "HardDrive", "PowerSupply", "FrontPanel", "Complete" };
        private Component component = new Component();
        private List<Component> list;
        private int i = 0;
        private int attempt = 0;

        public float totalGuesses = 0;
        public float corGuesses = 0;

        public GameObject buildBoard;
        public GameObject waitRing;
        public GameObject correctRing;
        public GameObject wrongRing;
        public ScoreKeeperScript scoreKeeper;

        void Start()
        {
            list = component.getList();
            scoreKeeper = this.gameObject.GetComponent<ScoreKeeperScript>();
            
        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnTriggerEnter(Collider other)
        {
        if (other.gameObject.tag == "Component")
            {
                totalGuesses++;
                if (other.gameObject.name == expectedObject[i])
                {
                    corGuesses++;
                    Debug.Log(i);
                    Component componentNew = list.Find(x => x.ComponentName == expectedObject[i]);
                    buildBoard.GetComponent<TextMeshPro>().text = "<b>Next Component \n-----------------------\nComponent # " + (i + 2) +"\n" + expectedObject[i + 1];
                    other.gameObject.transform.parent = null;
                    other.transform.position = componentNew.getXyzPoints();
                    other.transform.eulerAngles = componentNew.getRotatePoints();
                    Destroy(other.GetComponent<PickableItem>());
                    Destroy(other.GetComponent<Rigidbody>());
                    i++;
                    
                    StartCoroutine(correct(3));
                    
                    if (expectedObject[i] == "Complete")
                    {
                        scoreKeeper.completedBuild(corGuesses, totalGuesses);
                    }
                    
                    attempt = 0;
            }
                else
                {
                    attempt++;
                    StartCoroutine(incorrect(5));
                }
            }
        }

        IEnumerator correct(float seconds)
        {
        scoreKeeper.correctComponentPicked(attempt);
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        waitRing.gameObject.SetActive(false);
        correctRing.gameObject.SetActive(true);
        yield return new WaitForSeconds(seconds);
        this.gameObject.GetComponent<BoxCollider>().enabled = true;
        waitRing.gameObject.SetActive(true);
        correctRing.gameObject.SetActive(false);
    }

    IEnumerator incorrect(float seconds)
    {
        scoreKeeper.wrongComponentPicked();
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        waitRing.gameObject.SetActive(false);
        wrongRing.gameObject.SetActive(true);
        yield return new WaitForSeconds(seconds);
        this.gameObject.GetComponent<BoxCollider>().enabled = true;
        waitRing.gameObject.SetActive(true);
        wrongRing.gameObject.SetActive(false);
    }

}