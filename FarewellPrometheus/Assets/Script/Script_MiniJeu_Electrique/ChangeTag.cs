using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTag : MonoBehaviour
{
    public GameObject couleur;

    public bool ReJaune = false;    public bool ReCyan = false;      public bool ReMagenta = false;
    public bool ReVert = false;     public bool ReViolet = false;    public bool ReOrange = false;
    public bool ReSoufre = false;   public bool ReSafran = false;    public bool ReGrenat = false;
    public bool ReCapucine = false; public bool ReCampanule = false; public bool ReTurquoise = false;
    public bool ReBlack = false;

    void Update()
    {
        ReJaune = couleur.GetComponent<recepteur>().Jaune;
        ReCyan = couleur.GetComponent<recepteur>().Cyan;
        ReMagenta = couleur.GetComponent<recepteur>().Magenta;
        ReVert = couleur.GetComponent<recepteur>().Vert;
        ReViolet = couleur.GetComponent<recepteur>().Violet;
        ReOrange = couleur.GetComponent<recepteur>().Orange;
        ReSoufre = couleur.GetComponent<recepteur>().Soufre;
        ReSafran = couleur.GetComponent<recepteur>().Safran;
        ReGrenat = couleur.GetComponent<recepteur>().Grenat;
        ReCapucine = couleur.GetComponent<recepteur>().Capucine;
        ReCampanule = couleur.GetComponent<recepteur>().Campanule;
        ReTurquoise = couleur.GetComponent<recepteur>().Turquoise;
        ReBlack = couleur.GetComponent<recepteur>().Black;



        if (ReBlack == false)
        {
            if (ReJaune == false && ReCyan == false &&      ReMagenta == false &&
            ReVert == false &&      ReViolet == false &&    ReOrange == false &&
            ReSoufre == false &&    ReSafran == false &&    ReGrenat == false &&
            ReCapucine == false &&  ReCampanule == false && ReTurquoise == false)
            {
                transform.gameObject.tag = "Player";
            }
        }
        else
        {
            ReJaune = false;    ReCyan = false;      ReMagenta = false;
            ReVert = false;     ReViolet = false;    ReOrange = false;
            ReSoufre = false;   ReSafran = false;    ReGrenat = false;
            ReCapucine = false; ReCampanule = false; ReTurquoise = false;
            
            transform.gameObject.tag = "Player";


        }

        if (ReVert == false && ReViolet == false &&    ReOrange == false &&
        ReSoufre == false &&   ReSafran == false &&    ReGrenat == false &&
        ReCapucine == false && ReCampanule == false && ReTurquoise == false)
        {
            if (ReJaune == true ||
            ReCyan == true ||
            ReMagenta == true)
            {
                jeSuisPrimaire();
            }
        }
        if (
        !ReSoufre &&    !ReSafran &&    !ReGrenat &&
        !ReCapucine &&  !ReCampanule && !ReTurquoise)
        {
            if (ReVert == true ||
            ReViolet == true ||
            ReOrange == true)
            {
                jeSuisSecondaire();
            }
        }

            if (ReSoufre == true || ReSafran == true ||    ReGrenat == true ||
            ReCapucine == true ||   ReCampanule == true || ReTurquoise == true)
            {
                jeSuisTertiaire();
            }
        

    }

    void jeSuisPrimaire()
    {
        if (ReJaune == true)
        { transform.gameObject.tag = "Jaune"; }
        if (ReCyan == true)
        { transform.gameObject.tag = "Cyan"; }
        if (ReMagenta == true)
        { transform.gameObject.tag = "Magenta"; }
    }
    void jeSuisSecondaire()
    {
        if (ReVert == true)
        { transform.gameObject.tag = "Vert"; }
        if (ReViolet == true)
        { transform.gameObject.tag = "Violet"; }
        if (ReOrange == true)
        { transform.gameObject.tag = "Orange"; }

    }
    void jeSuisTertiaire()
    {

        if (ReSoufre == true)
        { transform.gameObject.tag = "Soufre"; }
        if (ReSafran == true)
        { transform.gameObject.tag = "Safran"; }
        if (ReGrenat == true)
        { transform.gameObject.tag = "Grenat"; }
        if (ReCapucine == true)
        { transform.gameObject.tag = "Capucine"; }
        if (ReCampanule == true)
        { transform.gameObject.tag = "Campanule"; }
        if (ReTurquoise == true)
        { transform.gameObject.tag = "Turquoise"; }
    }
}
