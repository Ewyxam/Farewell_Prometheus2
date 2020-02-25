using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float speedH = 1.0f;
    public float speedV = 1.0f;
    private Vector3 posInit;
    public GameObject manager;

    private float yaw = 0.0f;
    private float pitch = 0.0f;

    private void Start()
    {
        //voir comment recup position initiale
        posInit = transform.eulerAngles;
    }
    // Update is called once per frame
    void Update()
    {
        if (manager.GetComponent<SceneTransition>().transActive == 1)
        {
            transform.eulerAngles = posInit;
        }
        else
        {
            yaw += speedH * Input.GetAxis("Mouse X");
            pitch -= speedV * Input.GetAxis("Mouse Y");

            yaw = Mathf.Clamp(yaw, -4f, 4f);
            //the rotation range
            pitch = Mathf.Clamp(pitch, -5.6f, 5.6f);
            //the rotation range

            transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
        }
    }
}
