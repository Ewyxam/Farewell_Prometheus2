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
        

    }

    public void JgToCl()
    {
        discovered[tabNum] = true;
        tabNum -= 1;
        transition.GetComponent<SceneTransition>().LoadTransitionPanel();

    }

    public void JgToRv()
    {
        discovered[tabNum] = true;
        tabNum += 1;
        transition.GetComponent<SceneTransition>().LoadTransitionPanel();


    }

    public void RvToJg()
    {
        discovered[tabNum] = true;
        tabNum -= 1;
        transition.GetComponent<SceneTransition>().LoadTransitionPanel();


    }

    public void RvToCp()
    {
        discovered[tabNum] = true;
        tabNum += 1;
        transition.GetComponent<SceneTransition>().LoadTransitionPanel();


    }

    public void CpToRv()
    {
        discovered[tabNum] = true;
        tabNum -= 1;
        transition.GetComponent<SceneTransition>().LoadTransitionPanel();


    }



}
