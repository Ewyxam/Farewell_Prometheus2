using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorController : MonoBehaviour
{
    public static CursorController instance;

    public Texture2D normalCursor, handOpen, handClosed, arrow;

    private void Awake()
    {
        instance = this; 
       
    }

    public void ActivateNormalCursor()
    {
        Cursor.SetCursor(normalCursor, Vector2.zero, CursorMode.Auto);
    }


    public void ActivateHandOpen()
    {
        Cursor.SetCursor(handOpen, new Vector2(handOpen.width/2, handOpen.height/2), CursorMode.Auto);
    }

    public void ActivateHandClosed()
    {
        Cursor.SetCursor(handClosed, new Vector2(handClosed.width / 2, handClosed.height / 2), CursorMode.Auto);
    }

    public void ActivateArrow()
    {
        Cursor.SetCursor(arrow, new Vector2(arrow.width / 2, 0), CursorMode.Auto);
    }

}
