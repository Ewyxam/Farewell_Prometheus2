using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Look : MonoBehaviour
{
    private void OnMouseEnter()
    {
        CursorController.instance.ActivateMagnifyingGlass();
    }

    private void OnMouseExit()
    {
        CursorController.instance.ActivateNormalCursor();
    }
}
