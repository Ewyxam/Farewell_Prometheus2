using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    public GameObject[] tab;

    public void Test()
    {
        tab[0].SetActive(false);
        Debug.Log("c'est cliqué");
    }

  
   
}
