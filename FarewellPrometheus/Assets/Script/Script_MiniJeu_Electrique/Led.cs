using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Led : MonoBehaviour
{
    public GameObject couleur; // mettre le recepteur affilié à cette LED
    private SpriteRenderer render;
    public bool ReJaune = false;    public bool ReCyan = false;     public bool ReMagenta = false;
    public bool ReVert = false;     public bool ReViolet = false;   public bool ReOrange = false;
    public bool ReSoufre = false;   public bool ReSafran = false;   public bool ReGrenat = false;
    public bool ReCapucine = false; public bool ReCampanule = false;public bool ReTurquoise = false;
    public bool ReBlack = false;



    void Start()
    {
        render = GetComponent<SpriteRenderer>();
    }

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
            if (ReJaune == false &&
            ReCyan == false &&
            ReMagenta == false &&
            ReVert == false &&
            ReViolet == false &&
            ReOrange == false &&
            ReSoufre == false &&
            ReSafran == false &&
            ReGrenat == false &&
            ReCapucine == false &&
            ReCampanule == false &&
            ReTurquoise == false)
            {
                render.color = couleur.GetComponent<SpriteRenderer>().color;
            }
        }
        else
        {
            ReJaune = false;    ReCyan = false;         ReMagenta = false;
            ReVert = false;     ReViolet = false;       ReOrange = false;
            ReSoufre = false;   ReSafran = false;       ReGrenat = false;
            ReCapucine = false; ReCampanule = false;    ReTurquoise = false;
            render.color = Color.black;



        }

        if (ReVert == false &&
        ReViolet == false &&
        ReOrange == false &&
        ReSoufre == false &&
        ReSafran == false &&
        ReGrenat == false &&
        ReCapucine == false &&
        ReCampanule == false &&
        ReTurquoise == false)
        {
            
            if (ReJaune == true ||
            ReCyan == true ||
            ReMagenta == true)
            {
                jeSuisPrimaire();
        }
            if (ReJaune == false ||
ReCyan == false ||
ReMagenta == false)
            {
                jeSuisPrimaire();
            }
        }
        if (
        ReSoufre == false &&
        ReSafran == false &&
        ReGrenat == false &&
        ReCapucine == false &&
        ReCampanule == false &&
        ReTurquoise == false)
        {
            if (ReVert == true ||
            ReViolet == true ||
            ReOrange == true)
            {
                jeSuisSecondaire();
            }
        }

        if (ReSoufre == true ||
        ReSafran == true ||
        ReGrenat == true ||
        ReCapucine == true ||
        ReCampanule == true ||
        ReTurquoise == true)
        {
            jeSuisTertiaire();
        }


    }

    void jeSuisPrimaire()
    {
        if (ReJaune == true)
        { render.color = new Color(1f, 1f, 0.2f); }
        if (ReCyan == true)
        { render.color = new Color(0f, 0.3f, 1f); }
        if (ReMagenta == true)
        { render.color = new Color(1f, 0.15f, 0.07f); }
    }
    void jeSuisSecondaire()
    {
        if (ReVert == true)
        { render.color = new Color(0.4f, 0.6f, 0.2f); }
        if (ReViolet == true)
        { render.color = new Color(0.5f, 0f, 0.7f); }
        if (ReOrange == true)
        { render.color = new Color(1f, 0.6f, 0f); }

    }
    void jeSuisTertiaire()
    {

        if (ReSoufre == true)
        { render.color = new Color(0.8f, 0.9f, 0.2f); }
        if (ReSafran == true)
        { render.color = new Color(1f, 0.7f, 0f); }
        if (ReGrenat == true)
        { render.color = new Color(0.65f, 0.1f, 0.3f); }
        if (ReCapucine == true)
        { render.color = new Color(1f, 0.3f, 0.03f); }
        if (ReCampanule == true)
        { render.color = new Color(0.25f, 0f, 0.65f); }
        if (ReTurquoise == true)
        { render.color = new Color(0f, 0.6f, 0.8f); }
    }
}
