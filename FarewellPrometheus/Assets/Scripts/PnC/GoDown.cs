using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoDown : MonoBehaviour
{
    private void OnMouseEnter()
    {
        CursorController.instance.ActivateArrowDown();
    }

    private void OnMouseExit()
    {
        CursorController.instance.ActivateNormalCursor();
    }

}
