using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    public GameObject[] tab;
    public GameObject transition;
    public int tabNum;

    public void Start()
    {
        tabNum = 0; //0 CL   1JG  2RV   3CP
    }
    public void ClToJg()
    {
        
        tabNum += 1;
        transition.GetComponent<SceneTransition>().LoadTransitionPanel();
        AkSoundEngine.SetState("Location", "JG1");


    }

    public void JgToCl()
    {
        
        tabNum -= 1;
        transition.GetComponent<SceneTransition>().LoadTransitionPanel();
        AkSoundEngine.SetState("Location", "CL1");

    }

    public void JgToRv()
    {

        tabNum += 1;
        transition.GetComponent<SceneTransition>().LoadTransitionPanel();
        AkSoundEngine.SetState("Location", "RV1");


    }

    public void RvToJg()
    {

        tabNum -= 1;
        transition.GetComponent<SceneTransition>().LoadTransitionPanel();
        AkSoundEngine.SetState("Location", "JG1");

    }

    public void RvToCp()
    {

        tabNum += 1;
        transition.GetComponent<SceneTransition>().LoadTransitionPanel();
        AkSoundEngine.SetState("Location", "CP1");

    }

    public void CpToRv()
    {

        tabNum -= 1;
        transition.GetComponent<SceneTransition>().LoadTransitionPanel();
        AkSoundEngine.SetState("Location", "RV1");

    }



}
