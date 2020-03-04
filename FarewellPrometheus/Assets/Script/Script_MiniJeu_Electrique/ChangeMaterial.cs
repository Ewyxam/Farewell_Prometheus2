using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{

    public Sprite[] materialLed;
    SpriteRenderer rend;
    public bool test = false;
    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        rend.enabled = true;
        rend.sprite = materialLed[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (test)
        { ChangeCouleur(); }
    }

    public void ChangeCouleur()
    {
        rend.sprite = materialLed[1];
    }
}
