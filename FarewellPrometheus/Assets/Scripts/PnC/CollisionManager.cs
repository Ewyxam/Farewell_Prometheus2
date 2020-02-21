using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    public GameObject[] tab;
    public GameObject transition;
    public int tabNum;
    public bool[] discovered;

    public void Start()
    {
        tabNum = 0; //0 CL   1JG  2RV   3CP
    }
    public void ClToJg()
    {
        discovered[tabNum] = true;
        tabNum += 1;
        transition.GetComponent<SceneTransition>().LoadTransitionPanel();
        AkSoundEngine.SetState("Location", "JG1");


    }

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

    public void RvToJg()
    {
        discovered[tabNum] = true;
        tabNum -= 1;
        transition.GetComponent<SceneTransition>().LoadTransitionPanel();
        AkSoundEngine.SetState("Location", "JG1");

    }

    public void RvToCp()
    {
        discovered[tabNum] = true;
        tabNum += 1;
        transition.GetComponent<SceneTransition>().LoadTransitionPanel();
        AkSoundEngine.SetState("Location", "CP1");

    }

    public void CpToRv()
    {
        discovered[tabNum] = true;
        tabNum -= 1;
        transition.GetComponent<SceneTransition>().LoadTransitionPanel();
        AkSoundEngine.SetState("Location", "RV1");

    }



}
