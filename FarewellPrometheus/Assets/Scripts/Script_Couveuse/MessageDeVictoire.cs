using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class MessageDeVictoire : MonoBehaviour
{
    /* procédure sur Unity:
1 : crée un Empty
2 : dans le Empty mettre en enfant l'objet sur lequel va s'appiquer les triggers (animation, activation, transformation, translation etc.)
3 : crée un autre Empty que l'on peut nommer "Trigger" enfant du premier Empty sur lequel on ajoute un Collider, il faut cocher la case "isTrigger"
4 : attacher le script au Trigger qui contient le Collider et dans la case "Plateforme" ajouter l'objet sur lequel on va appliquer les triggers
5 : l'objet qui doit entrer en collision avec le Empty Trigger doit avoir lui aussi un Collider mais surtout un RIGIDBODY avec la case "IS KINEMATIC" cochée
*/
    public GameObject plateforme;                                                   //Référence à la plateforme
    public bool condition1 = false;
    public bool condition2 = false;
    public bool condition3 = false;
    GameObject Bouton1;
    GameObject Bouton2;
    GameObject Bouton3;
    GameObject Bouton4;
    GameObject Bouton5;
    GameObject Bouton6;


    void Start()
    {
        //plateforme.SetActive(false);                                            //Désactivation de la plateforme (message de victoire)
        Bouton1 = GameObject.Find("Button1HautGauche");
        Bouton2 = GameObject.Find("Button2MilieuGauche");
        Bouton3 = GameObject.Find("Button3BasGauche");
        Bouton4 = GameObject.Find("Button4HautDroit");
        Bouton5 = GameObject.Find("Button5MilieuDroit");
        Bouton6 = GameObject.Find("Button6BasDroit");

    }

    /* void Update ()
     {
         if (condition1 == true && condition2 == true && condition3 == true)         //A chaque frame on vérifie si le joueur a bien alligné lers cercles
         {
             //plateforme.SetActive(true);                                             //Activation de la plateforme si les conditions sont rempli
         } //else plateforme.SetActive(false);                                         //Désactivation de la plateforme si les conditions ne sont plus rempli
     }*/

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.name == "SPRITE_1")                                                 //Si le nom du gameObject du collider touché est égale à "nomDuGameObject"
        {
            condition1 = true;                                                      //Condition remplie
            Debug.Log("condition n°1 = " + condition1);
            Victoire();
        }
        if (col.name == "SPRITE_2")                                                 
        {
            condition2 = true;
            Debug.Log("condition n°2 = " + condition2);
            Victoire();

        }
        if (col.name == "SPRITE_3")                                                 
        {
            condition3 = true;
            Debug.Log("condition n°3 = " + condition2);
            Victoire();

        }

        AkSoundEngine.PostEvent("CV_Gears_Right_Event", gameObject);

    }

                                     
    private void OnTriggerExit2D(Collider2D col)                                    //Fonction de base qui permet de detecter quand un objet SORT dans une zone
    {
        if (col.name == "SPRITE_1")
        {
            condition1 = false;                                                     //Si le joueur change la position du gameObject, la condition redevient fausse
            Victoire();

        }
        if (col.name == "SPRITE_2")
        {
            condition2 = false;
            Victoire();

        }
        if (col.name == "SPRITE_3")
        {
            condition3 = false;
            Victoire();

        }
    }

    private void Victoire()
    {
        if (condition1 == true && condition2 == true && condition3 == true)
        {
            plateforme.GetComponent<Animator>().SetBool("Victoire", true);
            Bouton1.GetComponent<Button>().interactable = false;
            Bouton2.GetComponent<Button>().interactable = false;
            Bouton3.GetComponent<Button>().interactable = false;
            Bouton4.GetComponent<Button>().interactable = false;
            Bouton5.GetComponent<Button>().interactable = false;
            Bouton6.GetComponent<Button>().interactable = false;


        }
    }
}


