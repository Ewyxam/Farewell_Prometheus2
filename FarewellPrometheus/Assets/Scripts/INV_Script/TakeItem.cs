using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TakeItem : MonoBehaviour
{
    //applique ce script sur les objets dans la scène que l'on peux mettre dans l'inventaire
    Inventaire inventaire_script;
    /*public Image CouteauSuisseImg;                      // dans Unity, mettre ici l'image qui sera dans le Slot du Couteau Suisse
    public Image CisailleImg;                           // faire de même pour les objets suivant
    public Image FleurImg;                              // il n'est pas possible de faire autrement puisque
    public Image ChampignonImg;                         // chaque objet est différent et doit être posé dans une zone qui lui est spécifique
    public Image ViandeBeteImg;                         // de plus, le "find" ne fonctionne pas sur un objet désactivé, or les slots doivent être désacivé
    public Image OeufBeteImg;
    public Image FruitImg;
    public Image TeteVolgaImg;*/


    Image CouteauSuisseImg;                      // dans Unity, mettre ici l'image qui sera dans le Slot du Couteau Suisse
    Image CisailleImg;                           // faire de même pour les objets suivant
    Image FleurImg;                              // il n'est pas possible de faire autrement puisque
    Image ChampignonImg;                         // chaque objet est différent et doit être posé dans une zone qui lui est spécifique
    Image ViandeBeteImg;                         // de plus, le "find" ne fonctionne pas sur un objet désactivé, or les slots doivent être désacivé
    Image OeufBeteImg;
    Image FruitImg;
    Image TeteVolgaImg;


    //private Vector3 screenPoint;
    //private Vector3 initialPos;
    //private Vector3 offset;
    //public Image render;
    public bool deposableTakeItem = false;             //Bool qui sert a savoir si l'objet est déposable, il est utilisé dans le Script CastelDND
    Taille panelTaille;                                // Permet d'avoir accès au script de déroulement de l'inventaire (animation)





    void Start()
    {
        inventaire_script = GameObject.Find("InventoryCode").GetComponent<Inventaire>();  // permet de trouver le Caneva Inventaire
        panelTaille = GameObject.Find("Panneau").GetComponent<Taille>(); // Permet d'avoir accès au script de déroulement de l'inventaire
        CouteauSuisseImg = GameObject.Find("CouteauSuisseInv").GetComponent<Image>();
        CisailleImg = GameObject.Find("CisailleInv").GetComponent<Image>();
        FleurImg = GameObject.Find("FleurInv").GetComponent<Image>();
        ChampignonImg = GameObject.Find("ChampignonInv").GetComponent<Image>();
        ViandeBeteImg = GameObject.Find("ViandeBeteInv").GetComponent<Image>();
        OeufBeteImg = GameObject.Find("OeufBeteInv").GetComponent<Image>();
        FruitImg = GameObject.Find("FruitInv").GetComponent<Image>();
        TeteVolgaImg = GameObject.Find("TeteVolgaInv").GetComponent<Image>();

    }



    void OnMouseDown()                                          // il faut ajouter un collider pour que cette méthode fonctionne (ne fonctionne pas sur IOS)

    {


        switch (gameObject.name)                                // Permet d'appliquer les actions qu'on va effectuer en fonction du nom de l'objet sur lequel est situer ce script
        {
            case "CouteauSuisseItem":                           // on met le nom de l'objet sur lequel on veux appliquer les effets


                if (!deposableTakeItem)
                {
                    //int nrSlot = CouteauSuisseImg.transform.parent.GetSiblingIndex();
                    CouteauSuisseImg.GetComponent<AnimSlot>().AnimationSlotON();       // Déclenche l'animation du Slot
                    //inventaire_script.slot[nrSlot] = true;                                                   // indique à l'inventaire que le Slot devient true
                    //inventaire_script.UpdateTXT(nrSlot, inventaire_script.slot[nrSlot].ToString());               // permet à l'inventaire d'afficher l'état du slot (vrai ou faux en l'occurence)
                    CouteauSuisseImg.enabled = true;                                                    // active l'image de l'item dans l'inventaire
                  //  CouteauSuisseImg.transform.parent.GetComponent<PosHier>().PosiSlotSuivant();
                    gameObject.GetComponent<AnimItem>().AnimationItemON();                              // Déclenche l'animation de disparition de l'Item
                    //Debug.Log("CouteauSuisseItem" + nrSlot);
                }

                break;
            case "CisailleItem":
                if (!deposableTakeItem)
                {
                    //int nrSlot = CisailleImg.transform.parent.GetSiblingIndex();
                    CisailleImg.GetComponent<AnimSlot>().AnimationSlotON();
                    //inventaire_script.slot[nrSlot] = true;
                    //inventaire_script.UpdateTXT(nrSlot, inventaire_script.slot[nrSlot].ToString());
                    CisailleImg.enabled = true;
                  //  CisailleImg.transform.parent.GetComponent<PosHier>().PosiSlotSuivant();
                    gameObject.GetComponent<AnimItem>().AnimationItemON();                              // Déclenche l'animation de disparition de l'Item
                    //Debug.Log("CisailleItem" + nrSlot);

                }
                break;
            case "FleurItem":
                if (!deposableTakeItem)
                {
                   // int nrSlot = FleurImg.transform.parent.GetSiblingIndex();
                    FleurImg.GetComponent<AnimSlot>().AnimationSlotON();
                  //  inventaire_script.slot[nrSlot] = true;
                 //   inventaire_script.UpdateTXT(nrSlot, inventaire_script.slot[nrSlot].ToString());
                    FleurImg.enabled = true;
                 //   FleurImg.transform.parent.GetComponent<PosHier>().PosiSlotSuivant();
                    gameObject.GetComponent<AnimItem>().AnimationItemON();                              // Déclenche l'animation de disparition de l'Item

                }
                break;
            case "ChampignonItem":
                if (!deposableTakeItem)
                {
                   // int nrSlot = ChampignonImg.transform.parent.GetSiblingIndex();

                    ChampignonImg.GetComponent<AnimSlot>().AnimationSlotON();
                   // inventaire_script.slot[nrSlot] = true;
                  //  inventaire_script.UpdateTXT(nrSlot, inventaire_script.slot[nrSlot].ToString());
                    ChampignonImg.enabled = true;
                 //   ChampignonImg.transform.parent.GetComponent<PosHier>().PosiSlotSuivant();
                    gameObject.GetComponent<AnimItem>().AnimationItemON();                              // Déclenche l'animation de disparition de l'Item

                }
                break;
            case "ViandeBeteItem":
                if (!deposableTakeItem)
                {
                    //int nrSlot = ViandeBeteImg.transform.parent.GetSiblingIndex();

                    ViandeBeteImg.GetComponent<AnimSlot>().AnimationSlotON();
                  //  inventaire_script.slot[nrSlot] = true;
                  //  inventaire_script.UpdateTXT(nrSlot, inventaire_script.slot[nrSlot].ToString());
                    ViandeBeteImg.enabled = true;
                 //   ViandeBeteImg.transform.parent.GetComponent<PosHier>().PosiSlotSuivant();
                    gameObject.GetComponent<AnimItem>().AnimationItemON();                              // Déclenche l'animation de disparition de l'Item

                }
                break;
            case "OeufBeteItem":
                if (!deposableTakeItem)
                {
                  //  int nrSlot = OeufBeteImg.transform.parent.GetSiblingIndex();

                    OeufBeteImg.GetComponent<AnimSlot>().AnimationSlotON();
                  //  inventaire_script.slot[nrSlot] = true;
                   // inventaire_script.UpdateTXT(nrSlot, inventaire_script.slot[nrSlot].ToString());
                    OeufBeteImg.enabled = true;
                  //  OeufBeteImg.transform.parent.GetComponent<PosHier>().PosiSlotSuivant();
                    gameObject.GetComponent<AnimItem>().AnimationItemON();                              // Déclenche l'animation de disparition de l'Item

                }
                break;
            case "FruitItem":
                if (!deposableTakeItem)
                {
                  //  int nrSlot = FruitImg.transform.parent.GetSiblingIndex();

                    FruitImg.GetComponent<AnimSlot>().AnimationSlotON();
                  //  inventaire_script.slot[nrSlot] = true;
                 //   inventaire_script.UpdateTXT(nrSlot, inventaire_script.slot[nrSlot].ToString());
                    FruitImg.enabled = true;
                   // FruitImg.transform.parent.GetComponent<PosHier>().PosiSlotSuivant();
                    gameObject.GetComponent<AnimItem>().AnimationItemON();                              // Déclenche l'animation de disparition de l'Item

                }
                break;
            case "TeteVolgaItem":
                if (!deposableTakeItem)
                {
                   // int nrSlot = TeteVolgaImg.transform.parent.GetSiblingIndex();

                    TeteVolgaImg.GetComponent<AnimSlot>().AnimationSlotON();
                  //  inventaire_script.slot[nrSlot] = true;
                  //  inventaire_script.UpdateTXT(nrSlot, inventaire_script.slot[nrSlot].ToString());
                    TeteVolgaImg.enabled = true;
                  //  TeteVolgaImg.transform.parent.GetComponent<PosHier>().PosiSlotSuivant();

                    gameObject.GetComponent<AnimItem>().AnimationItemON();                              // Déclenche l'animation de disparition de l'Item
                }
                break;



        }
        
    }
    private void Action()
    {
        panelTaille.ouvertureDeIventaire();                                                 // Met à jour la taille de l'inventaire
        deposableTakeItem = true;                                                           // autorise l'item à être déposable, sera utile plus tard
        if (!inventaire_script.activation)                                                  // si l'inventaire est fermé, ouvre l'inventaire (fonction située dans le script "inventaire")
        {
            inventaire_script.activ();
        }
        transform.position = new Vector3(50, 50, gameObject.GetComponent<Transform>().transform.position.z);
        gameObject.GetComponent<CastelDND>().enabled = false;                               // Désactive le Drag and Drop de l'Item
    }
}
