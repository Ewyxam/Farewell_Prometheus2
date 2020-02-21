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
        

    }

    public void JgToCl()
    {
        
        tabNum -= 1;
        transition.GetComponent<SceneTransition>().LoadTransitionPanel();

    }

    public void JgToRv()
    {

        tabNum += 1;
        transition.GetComponent<SceneTransition>().LoadTransitionPanel();


    }

    public void RvToJg()
    {

        tabNum -= 1;
        transition.GetComponent<SceneTransition>().LoadTransitionPanel();


    }

    public void RvToCp()
    {

        tabNum += 1;
        transition.GetComponent<SceneTransition>().LoadTransitionPanel();


    }

    public void CpToRv()
    {

        tabNum -= 1;
        transition.GetComponent<SceneTransition>().LoadTransitionPanel();


    }



}
