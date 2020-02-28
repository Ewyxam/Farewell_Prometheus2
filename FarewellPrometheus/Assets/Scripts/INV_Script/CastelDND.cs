using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CastelDND : MonoBehaviour                          // attacher se script à l'objet que l'on souhaite deplacer
{

    private Vector3 screenPoint;
    private Vector3 initialPos;
    private Vector3 offset;                                      // permet de crée un décalage entre la souris et l'objet que l'on selectionne
    private Vector3 curPosition;                                 // position actuelle


    public bool canDrop;                                         // pour pouvoir ou non lacher l'objet
    private SpriteRenderer render;
    public Image InventaireImg;
    public bool activationDND = false;
    Taille panelTaille;
    //Inventaire inventaire;

    void Start()
    {
        render = GetComponent<SpriteRenderer>();
        activationDND = InventaireImg.GetComponent<select>().activationSelect;
        panelTaille = GameObject.Find("Panneau").GetComponent<Taille>();
        //canDrop = false;                                 // pour pouvoir ou non lacher l'objet

    }
    private void Update()
    {
        transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 13));
    }

    void OnMouseDown()                                          // il faut ajouter un collider pour que cette méthode fonctionne (ne fonctionne pas sur IOS)
    {

        if (GetComponent<TakeItem>().deposableTakeItem)
        {
            initialPos = gameObject.transform.position;
            screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);

            offset = initialPos - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
            if (GetComponent<CastelDND>().enabled == true)
            {
                if (canDrop)
                {
                    InventaireImg.GetComponent<AnimSlot>().AnimationSlotOFF();


                    //InventaireImg.transform.parent.GetComponent<PosHier>().PosiSlotDernier();
                    GetComponent<CastelDND>().enabled = false;
                    GetComponent<TakeItem>().deposableTakeItem = false;
                    //InventaireImg.transform.parent.gameObject.SetActive(false);
                    //panelTaille.ouvertureDeIventaire();

                    //int nrSlot = InventaireImg.transform.parent.GetSiblingIndex();

                    //inventaire.GetComponent<Inventaire>().slot[nrSlot] = false;
                    //Debug.Log("le Slot n° " + nrSlot + "est faux");
                }
                else
                {
                    InventaireImg.GetComponent<select>().ReSelection();
                    GetComponent<CastelDND>().enabled = false;
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {

        switch (gameObject.name)                                // Permet d'appliquer les actions qu'on va effectuer en fonction du nom de l'objet sur lequel est situer ce script
        {
            case "CouteauSuisseItem":
                if (col.name == "deposCouteauSuisseItem")
                { canDrop = true; }
                break;
            case "CisailleItem":
                if (col.name == "deposCisailleItem")
                { canDrop = true; }
                break;
            case "FleurItem":
                if (col.name == "deposFleurItem")
                { canDrop = true; }
                break;
            case "ChampignonItem":
                if (col.name == "deposChampignonItem")
                { canDrop = true; }
                break;
            case "ViandeBeteItem":
                if (col.name == "deposViandeBeteItem")
                { canDrop = true; }
                break;
            case "OeufBeteItem":
                if (col.name == "deposOeufBeteItem")
                { canDrop = true; }
                break;
            case "FruitItem":
                if (col.name == "deposFruitItem")
                { canDrop = true; }
                break;
            case "TeteVolgaItem":
                if (col.name == "deposTeteVolgaItem")
                { canDrop = true; }
                break;
        }

    }
    private void OnTriggerExit2D(Collider2D col)
    {
        switch (gameObject.name)                                // Permet d'appliquer les actions qu'on va effectuer en fonction du nom de l'objet sur lequel est situer ce script
        {
            case "CouteauSuisseItem":
                if (col.name == "deposCouteauSuisseItem")
                { canDrop = false; }
                break;
            case "CisailleItem":
                if (col.name == "deposCisailleItem")
                { canDrop = false; }
                break;
            case "FleurItem":
                if (col.name == "deposFleurItem")
                { canDrop = false; }
                break;
            case "ChampignonItem":
                if (col.name == "deposChampignonItem")
                { canDrop = false; }
                break;
            case "ViandeBeteItem":
                if (col.name == "deposViandeBeteItem")
                { canDrop = false; }
                break;
            case "OeufBeteItem":
                if (col.name == "deposOeufBeteItem")
                { canDrop = false;  }
                break;
            case "FruitItem":
                if (col.name == "deposFruitItem")
                { canDrop = false;  }
                break;
            case "TeteVolgaItem":
                if (col.name == "deposTeteVolgaItem")
                { canDrop = false; }
                break;
        }

    }
}