using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System;


    public class Inspect : MonoBehaviour
    {
    // Start is called before the first frame update
    private string[] expectedObject = { "ComputerCase", "Fan", "Fan", "Fan", "Fan", "MotherBoard", "CPU", "Ram", "Ram", "Ram", "Ram", "GPU", "GPU", "CoolingSystem", "HardDrive", "HardDrive", "PowerSupply", "FrontPanel" };
    private Component component = new Component();
        private List<Component> list;

        public GameObject inspectBoard;
        public GameObject BuildMarker;
        void Start()
        {
            list = component.getList();
        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Component")
            {
                    Component componentNew = list.Find(x => x.ComponentName == other.gameObject.name);
                    inspectBoard.GetComponent<TextMeshPro>().text = componentNew.getInspectBoardText();  
            }
        }


    } 