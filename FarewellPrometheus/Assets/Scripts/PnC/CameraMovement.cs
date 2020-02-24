using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float speedH = 1.0f;
    public float speedV = 1.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;

    // Update is called once per frame
    void Update()
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
