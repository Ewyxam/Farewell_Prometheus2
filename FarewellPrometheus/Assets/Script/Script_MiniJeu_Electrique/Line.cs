using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{
    private LineRenderer lineRend;
    private Vector3 initialPosLine;
    void Start()
    {
        lineRend = GetComponent<LineRenderer>();
        lineRend.positionCount = 2;
        initialPosLine.x = transform.position.x;
        initialPosLine.y = transform.position.y;
    }
    void Update()
    {
        lineRend.SetPosition(0, new Vector3(initialPosLine.x, initialPosLine.y, 0f));
        lineRend.SetPosition(1, new Vector3(transform.position.x, transform.position.y, 0f));
    }
}
