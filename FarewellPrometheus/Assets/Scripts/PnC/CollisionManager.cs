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
        tabNum = GameObject.Find("GameManager").GetComponent<GameManager>().numTab; //0 CL   1JG  2RV   3GR  4CP  5INT
       
    }

    //CL
    public void ClToJg()
    {
        discovered[tabNum] = true;
        tabNum += 1;
        transition.GetComponent<SceneTransition>().LoadTransitionPanel();
        AkSoundEngine.SetState("Location", "JG1");
        AkSoundEngine.PostEvent("CL1_to_JG1_Event", gameObject);



    }

    //JG
    public void JgToCl()
    {
        discovered[tabNum] = true;
        tabNum -= 1;
        transition.GetComponent<SceneTransition>().LoadTransitionPanel();
        AkSoundEngine.SetState("Location", "CL1");
        AkSoundEngine.PostEvent("CL1_to_JG1_Event", gameObject);

    }

    public void JgToRv()
    {
        discovered[tabNum] = true;
        tabNum += 1;
        transition.GetComponent<SceneTransition>().LoadTransitionPanel();
        AkSoundEngine.SetState("Location", "RV1");
        AkSoundEngine.PostEvent("CL1_to_JG1_Event", gameObject);


    }

    //RV
    public void RvToJg()
    {
        discovered[tabNum] = true;
        tabNum -= 1;
        transition.GetComponent<SceneTransition>().LoadTransitionPanel();
        AkSoundEngine.SetState("Location", "JG1");
        AkSoundEngine.PostEvent("CL1_to_JG1_Event", gameObject);

    }

    public void RvToGr()
    {
        discovered[tabNum] = true;
        tabNum += 1;
        transition.GetComponent<SceneTransition>().LoadTransitionPanel();
        AkSoundEngine.SetState("Location", "GR1");
        AkSoundEngine.SetState("Music", "Silence");
        AkSoundEngine.PostEvent("CL1_to_JG1_Event", gameObject);
    }
    public void RvToCp()
    {
        discovered[tabNum] = true;
        tabNum += 2;
        transition.GetComponent<SceneTransition>().LoadTransitionPanel();
        AkSoundEngine.SetState("Location", "CP1");
        AkSoundEngine.PostEvent("CL1_to_JG1_Event", gameObject);

    }

    //GR
    public void GrToRv()
    {
        discovered[tabNum] = true;
        tabNum -= 1;
        transition.GetComponent<SceneTransition>().LoadTransitionPanel();
        AkSoundEngine.SetState("Location", "RV1");
        AkSoundEngine.SetState("Music", "Exploration");
        AkSoundEngine.PostEvent("GR1_to_RV1_Event", gameObject);

    }

    //CP
    public void CpToRv()
    {
        discovered[tabNum] = true;
        tabNum -= 2;
        transition.GetComponent<SceneTransition>().LoadTransitionPanel();
        AkSoundEngine.SetState("Location", "RV1");
        AkSoundEngine.PostEvent("CL1_to_JG1_Event", gameObject);

    }

    public void CpToInt()
    {
        discovered[tabNum] = true;
        tabNum += 1;
        transition.GetComponent<SceneTransition>().LoadTransitionPanel();
        AkSoundEngine.SetState("Location", "CP2");
        AkSoundEngine.PostEvent("CP1_to_CP2_Event", gameObject);

    }

    //INT
    public void IntToCp()
    {
        discovered[tabNum] = true;
        tabNum -= 1;
        transition.GetComponent<SceneTransition>().LoadTransitionPanel();
        AkSoundEngine.SetState("Location", "CP1");
        AkSoundEngine.PostEvent("CP2_to_CP1_Event", gameObject);
    }


    }
