using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class MiniMapDrop : MonoBehaviour, IDropHandler
{
public void OnDrop(PointerEventData eventData)
    {
        RectTransform MiniMapLoc = transform as RectTransform;
        if(!RectTransformUtility.RectangleContainsScreenPoint(MiniMapLoc, Input.mousePosition))
        {
            Debug.Log("Yolo");

        }
    }
}
