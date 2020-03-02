using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject collMan, dialMan,transition;
    public bool couvClear, elecClear, grotteOk, combiOn, volgaAlive;
    public int day, campState,numTab;
    public Image[] campVisual;


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
    }

    


    void Update()
    {
        collMan = GameObject.Find("CollisionManager");
        numTab = collMan.GetComponent<CollisionManager>().tabNum;
        if (numTab ==5 && couvClear)
        {
            collMan.GetComponent<CollisionManager>().tab[0].SetActive(false);
            collMan.GetComponent<CollisionManager>().tab[numTab].SetActive(true);
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
