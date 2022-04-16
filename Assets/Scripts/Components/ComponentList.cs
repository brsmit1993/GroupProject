using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Component
{
    private List<Component> list = new List<Component>();
    private string componentName = "null";
    private string inspectBoardText;
    private int[] i = { 0, 0, 0, 0 };
    private Vector3[] rotatePoints;
    private Vector3[] xyzPoints;

    public string ComponentName { get => componentName; set => componentName = value; }

    public string getInspectBoardText()
    {
       
        return inspectBoardText;
    }
    public Vector3 getRotatePoints()
    {
       
        i[2]++;
        return rotatePoints[i[2] - 1];
    }

    public Vector3 getXyzPoints()
    {
       
        i[3]++;
        return xyzPoints[i[3] - 1];
    }


    public List<Component> getList()
    {
        Component computerCase = new Component();
        computerCase.ComponentName = "ComputerCase";
        computerCase.inspectBoardText = "A Computer Case is the outer \nshell of a computer. This \ncase is what the mother-\nboard, hard drives, cd drives, \netc are mounted to make the \ncomplete computer.";
        computerCase.rotatePoints = new Vector3[] { new Vector3(0, 90, 0) };
        computerCase.xyzPoints = new Vector3[] { new Vector3(-5.7f, 1.1f, 24.5f) };

        list.Add(computerCase);
        
        
        Component fan = new Component();
        fan.ComponentName = "Fan";
        fan.inspectBoardText = "A fan is a hardware device \nthat keeps the overall \ncomputer or a computer \ndevice cool by circulating air \nto or from the computer or \ncomponent.";
        fan.rotatePoints = new Vector3[] { new Vector3(0, 90, 0), new Vector3(0, 0, 0), new Vector3(0, 90, 0), new Vector3(90, 0, -90) };
        fan.xyzPoints = new Vector3[] { new Vector3(-5.827327f, 1.962f, 24.49912f), new Vector3(-5.608727f, 1.962f, 24.49912f), new Vector3(-6.038627f, 1.962f, 24.49912f), new Vector3(-6.165707f, 1.802f, 24.43843f) };
        list.Add(fan);

        Component coolingSystem = new Component();
        coolingSystem.ComponentName = "CoolingSystem";
        coolingSystem.inspectBoardText = "Computer cooling systems \nare passive or active systems \nthat are designed to regulate \nand dissipate the heat generated \nby a computer so as to \nmaintain optimal performance \nand protect the computer.";
        coolingSystem.rotatePoints = new Vector3[] { new Vector3(90, 180, 0) };
        coolingSystem.xyzPoints = new Vector3[] { new Vector3(-5.90722656f, 1.824f, 24.6344242f) };
        list.Add(coolingSystem);

        Component ram = new Component();
        ram.ComponentName = "Ram";
        ram.inspectBoardText = "Random access memory \n(RAM) is a computer's \nshort-term memory, which it \nuses to handle all active tasks \nand apps. None of your \nprograms, files, games, or \nstreams would work without RAM. ";
        ram.rotatePoints = new Vector3[] { new Vector3(90, 180, 0), new Vector3(90, 180, 0), new Vector3(90, 180, 0), new Vector3(90, 180, 0) };
        ram.xyzPoints = new Vector3[] { new Vector3(-5.75452662f, 1.81220007f, 24.6302242f), new Vector3(-5.78542662f, 1.81220007f, 24.6302242f), new Vector3(-5.81112671f, 1.81220007f, 24.6302242f), new Vector3(-5.72932673f, 1.81220007f, 24.6302242f) };
        list.Add(ram);

        Component hardDrive = new Component();
        hardDrive.ComponentName = "HardDrive";
        hardDrive.inspectBoardText = "A hard disk drive (HDD) is a non-\nvolatile computer storage device \ncontaining magnetic disks or \nplatters rotating at high speeds. \nIt is a secondary storage device \nused to store data permanently, \nrandom access memory (RAM) \nbeing the primary memory device.";
        hardDrive.rotatePoints = new Vector3[] { new Vector3(0,0,0), new Vector3(0, 0, 0) };
        hardDrive.xyzPoints = new Vector3[] { new Vector3(-5.585227f, 1.284999f, 24.50842f), new Vector3(-5.585227f, 1.186f, 24.50842f), };
        list.Add(hardDrive);

        Component motherBoard = new Component();
        motherBoard.ComponentName = "MotherBoard";
        motherBoard.inspectBoardText = "A printed circuit board containing \nthe principal components of a \ncomputer or other device, with \nconnectors into which other circuit \nboards can be slotted.";
        motherBoard.rotatePoints = new Vector3[] { new Vector3(90, 180, 0) };
        motherBoard.xyzPoints = new Vector3[] { new Vector3(-5.679227f, 1.368f, 24.63742f) };
        list.Add(motherBoard);

        Component graphicsCard = new Component();
        graphicsCard.ComponentName = "GPU";
        graphicsCard.inspectBoardText = "Graphics processing unit, a speci-\nalized processor originally \ndesigned to accelerate graphics \nrendering. GPUs can process \nmany pieces of data simultaneo-\nusly, making them useful for \nmachine learning, video editing, \nand gaming applications.";
        graphicsCard.rotatePoints = new Vector3[] { new Vector3(90, 180, 0), new Vector3(90, 180, 0), };
        graphicsCard.xyzPoints = new Vector3[] { new Vector3(-6.007227f, 1.586f, 24.63842f), new Vector3(-6.007227f, 1.495f, 24.63842f), };
        list.Add(graphicsCard);

        Component powerSupply = new Component();
        powerSupply.ComponentName = "PowerSupply";
        powerSupply.inspectBoardText = "A computer power supply converts \nAC into multiple DC voltages. \nFor example, 12 volts is \ncommonly used for drives, while \n3.3v and 5v are used by the chips \nand other motherboard compon-\nents.";
        powerSupply.rotatePoints = new Vector3[] { new Vector3(0, 270, 0) };
        powerSupply.xyzPoints = new Vector3[] { new Vector3(-6.005227f, 1.18f, 24.49842f) };
        list.Add(powerSupply);

        Component cpu = new Component();
        cpu.ComponentName = "CPU";
        cpu.inspectBoardText = "A CPU is the electronic circuitry \nthat executes instructions compr-\nising a computer program. The \nCPU performs basic arithmetic, \nlogic, controlling, and input/output \n(I/O) operations specified by the \ninstructions in the program.";
        cpu.rotatePoints = new Vector3[] { new Vector3(0, 0, 0) };
        cpu.xyzPoints = new Vector3[] { new Vector3(500, 500, 500) };
        list.Add(cpu);

        Component frontPanel = new Component();
        frontPanel.ComponentName = "FrontPanel";
        frontPanel.inspectBoardText = "Another part of the computer case that is used to protect the components from debris.";
        frontPanel.rotatePoints = new Vector3[] { new Vector3(0, 90, 0) };
        frontPanel.xyzPoints = new Vector3[] { new Vector3(-5.812056f, 1.580885f, 24.3083f) };
        list.Add(frontPanel);

        return list;
    }
    
    

    
}