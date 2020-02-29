using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapDND : MonoBehaviour                          // attacher se script à l'objet que l'on souhaite deplacer
{

    private Vector3 screenPoint;
    private Vector3 initialPos;
    private Vector3 offset;                                      // permet de crée un décalage entre la souris et l'objet que l'on selectionne
    private Vector3 curPosition;                                 // position actuelle


    void Start()
    {


        
    }
    private void Update()
    {
        //transform.position = curPosition;

    }

    void OnMouseDown()                                          // il faut ajouter un collider pour que cette méthode fonctionne (ne fonctionne pas sur IOS)
    {
        initialPos = gameObject.transform.position;
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);

        offset = initialPos - Camera.main.ScreenToWorldPoint(new Vector3 (Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));

        Debug.Log("on clique sur le sprite");
    }
    void OnMouseDrag()                                   // il faut ajouter un collider pour que cette méthode fonctionne (ne fonctionne pas sur IOS)
    {
        Debug.Log("On déplace la souri");
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);

        curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        transform.position = curPosition;

    }
}
