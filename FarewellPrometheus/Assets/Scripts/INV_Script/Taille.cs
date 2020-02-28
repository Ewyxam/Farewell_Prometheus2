using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Taille : MonoBehaviour
{
    // Attacher ce script au Panneau qui contient les slots de l'inventaire 
    Inventaire inventaireTaille;
    public bool Slot1;              // puisque les slots sont désactivé au Start, il fait les entrer dans se script manuelement *existe probablement une autre méthode
    public bool Slot2;
    public bool Slot3;
    public bool Slot4;
    public bool Slot5;
    public bool Slot6;
    public bool Slot7;
    public bool Slot8;
    public int xcv = 0;
    Animator anim;



    void Start()
    {
        inventaireTaille = GameObject.Find("InventoryCode").GetComponent<Inventaire>();
        anim = GetComponent<Animator>();
    }



    public void ouvertureDeIventaire()
    {
        majTailleInventaire();
        // si elle est vrai, on fait xcv = xcv + 1 se qui permet à l'animator de dérouler le bon nombre de cases
        anim.SetInteger("InvAnim", 8);
    }
    public void majTailleInventaire()
    {
        xcv = 8;                                                            // a chaque fois que l'inventaire est ouvert XCV doit être remis à 0

        /*foreach (bool emplacement in inventaireTaille.slot)             // pour chaque case du tableau du script de l'inventaire on vérifie si elle est vrai ou fausse
        {
            if (emplacement == true)
            {
                xcv += 1;
            }
        }*/
    }
}
