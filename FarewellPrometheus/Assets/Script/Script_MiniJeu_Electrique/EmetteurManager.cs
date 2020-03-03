using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmetteurManager : MonoBehaviour
{
    private Vector3 PositionInitiale;

    public bool CollisionAvecRecepteurN1 = false;
    public bool CollisionAvecRecepteurN2 = false;
    public bool CollisionAvecRecepteurN3 = false;
    public bool CollisionAvecRecepteurN4 = false;
    public bool CollisionAvecRecepteurN5 = false;
    public bool CollisionAvecRecepteurN6 = false;
    public bool CollisionAvecRecepteurN7 = false;
    public bool CollisionAvecRecepteurN8 = false;


    public bool emetteurPrimaire;
    public bool emetteurSecondaire;
    public bool emetteurTertiaire;
    public bool canDrop;

    public bool EmetteurON = false;

    GameObject controleur;

    private void Start()
    {
        GetComponent<DND>().enabled = false;
        PositionInitiale = transform.position;
        controleur = GameObject.Find("Controleur");
    }
    private void OnMouseDown()
    {
        switch (gameObject.name) {
            case("Emetteur1"):{
                    if (controleur.GetComponent<desactivEmeteur>().Emetteur1estBloque == false)
                    { GetComponent<DND>().enabled = !GetComponent<DND>().enabled; }
                    break;
                }
            case ("Emetteur2"):
                {
                    if (controleur.GetComponent<desactivEmeteur>().Emetteur2estBloque == false)
                    { GetComponent<DND>().enabled = !GetComponent<DND>().enabled;  }
                    break;
                }
            case ("Emetteur3"):
                {
                    if (controleur.GetComponent<desactivEmeteur>().Emetteur3estBloque == false)
                    { GetComponent<DND>().enabled = !GetComponent<DND>().enabled; }
                    break;
                }
            case ("Emetteur4"):
                {
                    if (controleur.GetComponent<desactivEmeteur>().Emetteur4estBloque == false)
                    { GetComponent<DND>().enabled = !GetComponent<DND>().enabled; }
                    break;
                }
            case ("Emetteur5"):
                {
                    if (controleur.GetComponent<desactivEmeteur>().Emetteur5estBloque == false)
                    { GetComponent<DND>().enabled = !GetComponent<DND>().enabled; }
                    break;
                }
            case ("Emetteur6"):
                {
                    if (controleur.GetComponent<desactivEmeteur>().Emetteur6estBloque == false)
                    { GetComponent<DND>().enabled = !GetComponent<DND>().enabled; }
                    break;
                }
            case ("Emetteur7"):
                {
                    if (controleur.GetComponent<desactivEmeteur>().Emetteur7estBloque == false)
                    { GetComponent<DND>().enabled = !GetComponent<DND>().enabled; }
                    break;
                }
            case ("Emetteur8"):
                {
                    if (controleur.GetComponent<desactivEmeteur>().Emetteur8estBloque == false)
                    { GetComponent<DND>().enabled = !GetComponent<DND>().enabled; }
                    break;
                }
            case ("Emetteur9"):
                {
                    if (controleur.GetComponent<desactivEmeteur>().Emetteur9estBloque == false)
                    { GetComponent<DND>().enabled = !GetComponent<DND>().enabled; }
                    break;
                }
            case ("Emetteur10"):
                {
                    if (controleur.GetComponent<desactivEmeteur>().Emetteur10estBloque == false)
                    { GetComponent<DND>().enabled = !GetComponent<DND>().enabled; }
                    break;
                }
            case ("Emetteur11"):
                {
                    { GetComponent<DND>().enabled = !GetComponent<DND>().enabled; }
                    break;
                }
            case ("Emetteur12"):
                {
                    { GetComponent<DND>().enabled = !GetComponent<DND>().enabled; }
                    break;
                }
        }
        if (canDrop == false)
        {
            transform.position = PositionInitiale;
        }
        if (canDrop == true)
        {
            if (CollisionAvecRecepteurN1 == true)
            {
                transform.position = GameObject.Find("Recepteur1").GetComponent<Transform>().transform.position;
                EmetteurON = true;
            }

            if (CollisionAvecRecepteurN2 == true)
            {
                transform.position = GameObject.Find("Recepteur2").GetComponent<Transform>().transform.position;
                EmetteurON = true;
            }

            if (CollisionAvecRecepteurN3 == true)
            {
                transform.position = GameObject.Find("Recepteur3").GetComponent<Transform>().transform.position;
                EmetteurON = true;
            }

            if (CollisionAvecRecepteurN4 == true)
            {
                transform.position = GameObject.Find("Recepteur4").GetComponent<Transform>().transform.position;
                EmetteurON = true;
            }

            if (CollisionAvecRecepteurN5 == true)
            {
                transform.position = GameObject.Find("Recepteur5").GetComponent<Transform>().transform.position;
                EmetteurON = true;            }

            if (CollisionAvecRecepteurN6 == true)
            {
                transform.position = GameObject.Find("Recepteur6").GetComponent<Transform>().transform.position;
                EmetteurON = true;
            }

            if (CollisionAvecRecepteurN7 == true)
            {
                transform.position = GameObject.Find("Recepteur7").GetComponent<Transform>().transform.position;
                EmetteurON = true;
            }

            if (CollisionAvecRecepteurN8 == true)
            {
                transform.position = GameObject.Find("Recepteur8").GetComponent<Transform>().transform.position;
                EmetteurON = true;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D col)         // il faut ajouter un rigidbody à l'objet et il faut cocher la case "Is Trigger" dans le collider
    {
        if (emetteurPrimaire == true)
        {
            if (col.tag == "RecepteurPri")
            { canDrop = true; }

            if (col.tag == "RecepteurSec")
            { canDrop = true; }
        }

        if (emetteurSecondaire == true)
        {
            if (col.tag == "RecepteurPri")
            { canDrop = false; }
            if (col.tag == "RecepteurSec")
            { canDrop = true; }
        }

        if (emetteurTertiaire == true)
        {
            if (col.tag == "RecepteurPri")
            {
                canDrop = false;
            }
            if (col.tag == "RecepteurSec") { canDrop = false; }
        }


        if (col.tag == "RecepteurTer")
        { canDrop = true; }

        if (col.name == "Recepteur1")
        { CollisionAvecRecepteurN1 = true; }

        if (col.name == "Recepteur2")
        { CollisionAvecRecepteurN2 = true; }

        if (col.name == "Recepteur3")
        { CollisionAvecRecepteurN3 = true; }

        if (col.name == "Recepteur4")
        { CollisionAvecRecepteurN4 = true; }

        if (col.name == "Recepteur5")
        { CollisionAvecRecepteurN5 = true; }

        if (col.name == "Recepteur6")
        { CollisionAvecRecepteurN6 = true; }

        if (col.name == "Recepteur7")
        { CollisionAvecRecepteurN7 = true; }

        if (col.name == "Recepteur8")
        { CollisionAvecRecepteurN8 = true; }
    }

    private void OnTriggerExit2D(Collider2D col)
    {

        {
            if (emetteurPrimaire == true)
            {
                if (col.tag == "RecepteurPri")
                { canDrop = false; }

                if (col.tag == "RecepteurSec")
                { canDrop = false; }
            }

            if (emetteurSecondaire == true)
            {
                if (col.tag == "RecepteurPri")
                { canDrop = false; }
                if (col.tag == "RecepteurSec")
                { canDrop = false; }
            }

            if (emetteurTertiaire == true)
            {
                if (col.tag == "RecepteurPri")
                {
                    canDrop = false;
                }
                if (col.tag == "RecepteurSec") { canDrop = false; }
            }


            if (col.tag == "RecepteurTer")
            { canDrop = false; }

            if (col.name == "Recepteur1")
            { CollisionAvecRecepteurN1 = false; }

            if (col.name == "Recepteur2")
            { CollisionAvecRecepteurN2 = false; }

            if (col.name == "Recepteur3")
            { CollisionAvecRecepteurN3 = false; }

            if (col.name == "Recepteur4")
            { CollisionAvecRecepteurN4 = false; }

            if (col.name == "Recepteur5")
            { CollisionAvecRecepteurN5 = false; }

            if (col.name == "Recepteur6")
            { CollisionAvecRecepteurN6 = false; }

            if (col.name == "Recepteur7")
            { CollisionAvecRecepteurN7 = false; }

            if (col.name == "Recepteur8")
            { CollisionAvecRecepteurN8 = false; }

            if (!CollisionAvecRecepteurN1&&
                !CollisionAvecRecepteurN2&&
                !CollisionAvecRecepteurN3&&
                !CollisionAvecRecepteurN4&&
                !CollisionAvecRecepteurN5&&
                !CollisionAvecRecepteurN6&&
                !CollisionAvecRecepteurN7&&
                !CollisionAvecRecepteurN8)
            { EmetteurON = false; }
        }
    }
}
