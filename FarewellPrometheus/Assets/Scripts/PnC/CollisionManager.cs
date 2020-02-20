using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    public GameObject[] tab;
    public int tabNum;

    public void Start()
    {
        tabNum = 0;
    }
    public void ClToJg()
    {
        tab[tabNum].SetActive(false);
        tabNum += 1;
        tab[tabNum].SetActive(true);

    }

    public void JgToCl()
    {
        tab[tabNum].SetActive(false);
        tabNum -= 1;
        tab[tabNum].SetActive(true);

    }



}
