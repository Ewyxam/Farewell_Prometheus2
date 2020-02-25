using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab : MonoBehaviour
{
    private bool canGrab,clicked;

    // Update is called once per frame
    private void OnMouseDown()
    {
        
        if(canGrab)
        {
            if(!clicked)
            {
                CursorController.instance.ActivateHandClosed();
                clicked = true;
            } else if (clicked)
            {
                CursorController.instance.ActivateHandOpen();
                clicked = false;
            }
            

        }
    }

    private void OnMouseEnter()
    {
        CursorController.instance.ActivateHandOpen();
        canGrab = true;

    }

    private void OnMouseExit()
    {
        CursorController.instance.ActivateNormalCursor();
        canGrab = false;
        clicked = false;
    }
    
}
