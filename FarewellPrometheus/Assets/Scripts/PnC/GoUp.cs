using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoUp : MonoBehaviour
{
    private void OnMouseEnter()
    {
        CursorController.instance.ActivateArrow();
    }

    private void OnMouseExit()
    {
        CursorController.instance.ActivateNormalCursor();
    }

}
