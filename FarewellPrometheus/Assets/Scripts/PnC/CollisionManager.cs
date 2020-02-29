using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour //Gerer les collisions et les transitions entre les tableaux
{
    public GameObject[] tab;
    public GameObject transition;
    public int tabNum;
    public bool[] discovered;

    public void Start()
    {
        tabNum = 0; //0 CL   1JG  2RV   3GR  4CP  5INT
    }

    //CL
    public void ClToJg()
    {
        discovered[tabNum] = true;
        tabNum += 1;
        transition.GetComponent<SceneTransition>().LoadTransitionPanel();
        AkSoundEngine.SetState("Location", "JG1");



    }

    //JG
    public void JgToCl()
    {
        discovered[tabNum] = true;
        tabNum -= 1;
        transition.GetComponent<SceneTransition>().LoadTransitionPanel();
        AkSoundEngine.SetState("Location", "CL1");

    }

    public void JgToRv()
    {
        discovered[tabNum] = true;
        tabNum += 1;
        transition.GetComponent<SceneTransition>().LoadTransitionPanel();
        AkSoundEngine.SetState("Location", "RV1");


    }

    //RV
    public void RvToJg()
    {
        discovered[tabNum] = true;
        tabNum -= 1;
        transition.GetComponent<SceneTransition>().LoadTransitionPanel();
        AkSoundEngine.SetState("Location", "JG1");

    }

    public void RvToGr()
    {
        discovered[tabNum] = true;
        tabNum += 1;
        transition.GetComponent<SceneTransition>().LoadTransitionPanel();
        AkSoundEngine.SetState("Location", "GR1");
        AkSoundEngine.SetState("Music", "Silence");
    }
    public void RvToCp()
    {
        discovered[tabNum] = true;
        tabNum += 2;
        transition.GetComponent<SceneTransition>().LoadTransitionPanel();
        AkSoundEngine.SetState("Location", "CP1");

    }

    //GR
    public void GrToRv()
    {
        discovered[tabNum] = true;
        tabNum -= 1;
        transition.GetComponent<SceneTransition>().LoadTransitionPanel();
        AkSoundEngine.SetState("Location", "RV1");
        AkSoundEngine.SetState("Music", "Exploration");

    }

    //CP
    public void CpToRv()
    {
        discovered[tabNum] = true;
        tabNum -= 2;
        transition.GetComponent<SceneTransition>().LoadTransitionPanel();
        AkSoundEngine.SetState("Location", "RV1");

    }

    public void CpToInt()
    {
        discovered[tabNum] = true;
        tabNum += 1;
        transition.GetComponent<SceneTransition>().LoadTransitionPanel();
        AkSoundEngine.SetState("Location", "CP2");

    }

    //INT
    public void IntToCp()
    {
        discovered[tabNum] = true;
        tabNum -= 1;
        transition.GetComponent<SceneTransition>().LoadTransitionPanel();
        AkSoundEngine.SetState("Location", "CP1");
    }


    }
