using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventaire : MonoBehaviour
{

    public bool activation = false;                         // Bool qui gère le rendu de l'inventaire (visible ou non)
    public GameObject Panel;                                // Mettre le Panneau qui contient l'inventaire
    public bool [] slot;                                     // déclaration du tableau qui contiendra les slots de l'inventaire

    //public List <bool> slot;                                     // déclaration du tableau qui contiendra les slots de l'inventaire
    void Start()
    {
        //GetComponent<Canvas>().enabled = false;             // au départ, l'invenaire est fermé
        slot = new bool[Panel.transform.childCount];        // on crée un tableau de booléen avec autant d'emplacement que le Panel à d'enfants (childCount = nombre d'enfant)
        //slot.Add(Panel.transform.childCount);

    }

    public void UpdateTXT(int nrslot, string txt)
    {
        Panel.transform.GetChild(nrslot).GetChild(1).GetComponent<Text>().text = txt;
    }
    private void OnMouseDown()                              // Méthode qui se déclenche au clic //il faut mettre un Collider2D sur l'icone de l'inventaire
    {
            activation = !activation;                       // lorsque l'on clic sur l'icone de l'inventaire, s'il est ouvert il se ferme, s'il est fermé il s'ouvre.
            //GetComponent<Canvas>().enabled = activation;    // le component "Caneva" est l'équivalent du renderer pour un GameObject 3D. Ici, on rend ou pas visible le contenu de l'inventaire
            Panel.GetComponent<Animator>().SetBool("InvOpen", activation);
        
        
        Debug.Log("Item 1" + slot[0]);
        Debug.Log("Item 2" + slot[1]);
        Debug.Log("Item 3" + slot[2]);
        Debug.Log("Item 4" + slot[3]);
        Debug.Log("Item 5" + slot[4]);
        Debug.Log("Item 6" + slot[5]);
        Debug.Log("Item 7" + slot[6]);
        Debug.Log("Item 8" + slot[7]);

    }

    public void activ()                                     // activ est appeler par le script "TakeItem" si l'inventaire est fermé afin de l'ouvrir quand on selectionne un objet dans la scène 
    {
        GetComponent<Canvas>().enabled = true;              // puisqu'il n'y a pas d'Update qui dit "Caneva.enabled = activation" il faut s'assurer que activation = true lorsque Caneva.enabler = true
        activation = true;
        Panel.GetComponent<Animator>().SetBool("InvOpen", true);
    }

}
