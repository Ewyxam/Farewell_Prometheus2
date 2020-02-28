using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class select : MonoBehaviour
{
    // attacher se script à l'image de l'item dans l'inventaire
    Inventaire inventaire_script;

    Image render;                                                   //le mettre lui-même
    public bool activationSelect = false;                           // je sais plus a quoi sert ce truc, mais ça a l'air important
    public GameObject Item;                                         //Mettre l'item qui correspond
    public GameObject Panneau;


    private void Start()
    {
        inventaire_script = GameObject.Find("InventoryCode").GetComponent<Inventaire>();
        render = GetComponent<Image>();
        render.enabled = false;
        Item.GetComponent<CastelDND>().enabled = false;
        //this.transform.parent.gameObject.SetActive(false);

    }





    public void Selection()
    {

        //int nrSlot = transform.parent.GetSiblingIndex();

        //inventaire_script.UpdateTXT(nrSlot, inventaire_script.slot[nrSlot].ToString());

        render.enabled = false;
        //activationSelect = true;
        Item.GetComponent<CastelDND>().enabled = true;
        Item.GetComponent<SpriteRenderer>().enabled = true;
        Item.GetComponent<AnimItem>().AnimationItemOFF();
        Item.GetComponent<Transform>().localScale = new Vector3(1, 1, 1);


        if (Item.GetComponent<CastelDND>().canDrop == true)
        {
            this.GetComponent<Animator>().SetBool("Slot1Anim", false);
            //this.transform.parent.GetComponent<PosHier>().PosiSlotDernier();
            //inventaire_script.slot[nrSlot] = false;
            
            /*switch (gameObject.name)
            {
                case "CouteauSuissInv":
                    inventaire_script.slot[nrSlot] = false;
                    Panneau.GetComponent<Taille>().majTailleInventaire();
                    Debug.Log("Parent de Couteau Suisse Inventaire est " + nrSlot);

                    break;
                case "CisailleInv":
                        inventaire_script.slot[1] = false;
                    Panneau.GetComponent<Taille>().majTailleInventaire();

                    break;
                case "FleurInv":
                        inventaire_script.slot[2] = false;
                    Panneau.GetComponent<Taille>().majTailleInventaire();
                    break;
                case "ChampignonInv":
                        inventaire_script.slot[3] = false;
                    Panneau.GetComponent<Taille>().majTailleInventaire();
                    break;
                case "ViandeBeteInv":
                        inventaire_script.slot[4] = false;
                    Panneau.GetComponent<Taille>().majTailleInventaire();
                    break;
                case "OeufBeteInv":
                        inventaire_script.slot[5] = false;
                    Panneau.GetComponent<Taille>().majTailleInventaire();
                    break;
                case "FruitInv":
                        inventaire_script.slot[6] = false;
                    Panneau.GetComponent<Taille>().majTailleInventaire();
                    break;
                case "TeteVolgaInv":
                        inventaire_script.slot[7] = false;
                    Panneau.GetComponent<Taille>().majTailleInventaire();
                    break;
            }*/
          


        }


    }
    public void ReSelection()
    {
        //int nrSlot = transform.parent.GetSiblingIndex();
        //inventaire_script.slot[nrSlot] = true;
        //inventaire_script.UpdateTXT(nrSlot, inventaire_script.slot[nrSlot].ToString());
        Item.GetComponent<CastelDND>().enabled = false;
        Item.GetComponent<Transform>().transform.position = new Vector3(50, 50, Item.GetComponent<Transform>().transform.position.z);
        render.enabled = true;

    }
}
