using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject collMan, dialMan,transition;
    public bool couvClear, elecClear, grotteOk, combiOn, volgaAlive,test;
    public int day, campState,numTab;
    public Sprite[] campVisual;
    
    

    void Start()
    {
        collMan = GameObject.Find("CollisionManager");
        transition = GameObject.Find("SceneTransition");
        grotteOk = true;
        combiOn = true;
        volgaAlive = true;
        day = 1;
        campState = 0;
        numTab = 0;
        test = true;
    }

    


    void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();

        dialMan = GameObject.Find("DialogueManager");
        transition = GameObject.Find("SceneTransition");
        collMan = GameObject.Find("CollisionManager");
        if (currentScene.name == "PhasePnC")
        {
            numTab = collMan.GetComponent<CollisionManager>().tabNum;


            if (numTab == 5 && elecClear)
            {
                collMan.GetComponent<CollisionManager>().tab[0].SetActive(false);
                collMan.GetComponent<CollisionManager>().tab[numTab].SetActive(true);
                GameObject.Find("INT_BG").GetComponent<Image>().sprite = campVisual[1];
                transition.GetComponent<SceneTransition>().tabNum = 5;

            }
            else
            if (numTab == 5 && couvClear && test == true)
            {
                collMan.GetComponent<CollisionManager>().tab[0].SetActive(false);
                collMan.GetComponent<CollisionManager>().tab[numTab].SetActive(true);
                GameObject.Find("INT_BG").GetComponent<Image>().sprite = campVisual[2];
                transition.GetComponent<SceneTransition>().tabNum = 5;
                test = false;
            }
        }

            //GIT BORDEL REPERE MON TRUC
        

    }



    public void LaunchCouv()
    {
        if(elecClear && !couvClear)
        {
            transition.GetComponent<SceneTransition>().LoadNextScene();
        }
    }

    public void LaunchElec()
    {
        if (!elecClear)
        {
            transition.GetComponent<SceneTransition>().LoadNextScene();
        }
    }

    public void ElecOk()
    {
        elecClear = true;
    }

}
