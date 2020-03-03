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
    int buildIndex;
    private Scene currentScene;

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
        

        if (transition.GetComponent<SceneTransition>().buildIndex == 1 )
        {
            collMan = GameObject.Find("CollisionManager");
            numTab = collMan.GetComponent<CollisionManager>().tabNum;
            if (numTab == 5 && couvClear && test == true)
            {
                collMan.GetComponent<CollisionManager>().tab[0].SetActive(false);
                collMan.GetComponent<CollisionManager>().tab[numTab].SetActive(true);
                GameObject.Find("INT_BG").GetComponent<Image>().sprite = campVisual[2];
                test = false;
            }
        }

    }



    public void LaunchCouv()
    {
        if(elecClear && !couvClear)
        {
            transition.GetComponent<SceneTransition>().LoadNextScene();
        }
    }

   
}
