using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ActivZonedeposable : MonoBehaviour
{
    public GameObject scene;
    void Start()
    {
        GetComponent<BoxCollider2D>().enabled = false;
    }

    void Update()
    {
        if (scene.activeSelf)
        {
            GetComponent<SpriteRenderer>().enabled = true;
            GetComponent<BoxCollider2D>().enabled = true;
        }

        if (scene.activeInHierarchy == false)
        {
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<BoxCollider2D>().enabled = false;
        }
    }
}
