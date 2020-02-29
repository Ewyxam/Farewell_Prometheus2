using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorController : MonoBehaviour
{
    public static CursorController instance;

    public Texture2D normalCursor, handOpen, handClosed, arrow, arrowDown, magnifyingGlass;

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

    public void ActivateArrowDown()
    {
        Cursor.SetCursor(arrowDown, new Vector2(arrowDown.width / 2, arrowDown.height -1), CursorMode.Auto);
    }

    public void ActivateMagnifyingGlass()
    {
        Cursor.SetCursor(magnifyingGlass, new Vector2(handOpen.width / 2, handOpen.height / 2), CursorMode.Auto);
    }
}
