using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MiniMapDrag : MonoBehaviour, IDragHandler, IEndDragHandler
{
    CollisionManager ColMan;
    public int TableauN;
    public float positionY;

    void Start()
    {
        ColMan = GameObject.Find("CollisionManager").GetComponent<CollisionManager>();
    }
    private void Update()
    {
        TableauN = ColMan.tabNum;
        positionY = transform.position.y;
    }

    public void OnDrag(PointerEventData eventData)                                          // lorsque l'on clique-maintien sur la map
    {
        transform.position = Input.mousePosition; //+ new Vector3(-120, 30, 0);
        if (ColMan.tabNum == 0)                                                             // on vérifie le tableau afin que lorsqu'on clique sur la minimap la souris se positionne au centre de la représentation du tableau sur la minimap
        {
            if (ColMan.discovered[1] == false)
            {
                    
            }
        }
        if (ColMan.tabNum == 1)
        {

        }
    }
    public void OnEndDrag(PointerEventData eventData)                                       // lorsqu'on relache la minimap se repositionne automatiquement sur la position actuelle du joueur
    {
        //transform.localPosition = new Vector3(-20, 30f, 0f);

/*        if (ColMan.tabNum == 0)
        {
            //transform.localPosition = Vector3.zero;
        }
        if (ColMan.tabNum == 1)
        {
            transform.localPosition = new Vector3(-80, -30, 0);
        }*/
    }
}
