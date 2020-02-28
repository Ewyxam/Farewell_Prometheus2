using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject collMan, dialMan,transition;
    public bool couvClear, elecClear, grotteOk, combiOn, volgaAlive;
    public int day, campState;
    public Image[] campVisual;


    void Start()
    {
        transition = GameObject.Find("SceneTransition");
        grotteOk = true;
        combiOn = true;
        volgaAlive = true;
        day = 1;
        campState = 0;
    }

    


    void Update()
    {
        
    }



    public void LaunchCouv()
    {
        if(elecClear && !couvClear)
        {
            transition.GetComponent<SceneTransition>().LoadNextScene();
        }
    }
}
