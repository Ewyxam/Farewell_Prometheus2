﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MiniMap : MonoBehaviour
{
    CollisionManager ColMan;
    public GameObject CL_MM;
    public GameObject JG_MM;
    public GameObject CP_MM;
    public GameObject INT_MM;
    public GameObject RV_MM;
    public GameObject GR_MM;



    void Start()
    {
        ColMan = GameObject.Find("CollisionManager").GetComponent<CollisionManager>();
    /*CL_MM.GetComponent<RawImage>().enabled = false;
    JG_MM.GetComponent<RawImage>().enabled = false;
    CP_MM.GetComponent<RawImage>().enabled = false;
    INT_MM.GetComponent<RawImage>().enabled = false;
    RV_MM.GetComponent<RawImage>().enabled = false;
    GR_MM.GetComponent<RawImage>().enabled = false;*/
}
    /*public void MajMiniMap()
    {
        if (ColMan.discovered[0])
        {
            CL_MM.GetComponent<RawImage>().enabled = true;
        } else CL_MM.GetComponent<RawImage>().enabled = false;
        if (ColMan.discovered[1])
        {
            JG_MM.GetComponent<RawImage>().enabled = true;
        } else JG_MM.GetComponent<RawImage>().enabled = false;
        if (ColMan.discovered[2])
        {
            CP_MM.GetComponent<RawImage>().enabled = true;
        }
        if (ColMan.discovered[3])
        {
            INT_MM.GetComponent<RawImage>().enabled = true;
        }
        if (ColMan.discovered[4])
        {
            RV_MM.GetComponent<RawImage>().enabled = true;
        }
        if (ColMan.discovered[5])
        {
            GR_MM.GetComponent<RawImage>().enabled = true;
        }

        if (ColMan.tabNum == 0)
        {
            CL_MM.GetComponent<RawImage>().color = Color.black;
        } 
        //Debug.Log(ColMan.tabNum);
        //Debug.Log(ColMan.discovered[0]);


    }*/
}
