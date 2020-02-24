using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseFollow : MonoBehaviour
{
    public float posX, posY;

    public float speedH = 1.0f;
    public float speedV = 1.0f;

    //public GameObject pointer;


    // Update is called once per frame
    void Update()
    {
        posX += speedH * Input.GetAxis("Mouse X");
        posY += speedV * Input.GetAxis("Mouse Y");

        

        transform.position = new Vector3(posX, posY, 0.0f);
    }
}
