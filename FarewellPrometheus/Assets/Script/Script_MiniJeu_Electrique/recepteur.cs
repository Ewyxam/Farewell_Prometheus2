using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class recepteur : MonoBehaviour
{
    private SpriteRenderer render;

    GameObject Emetteur1; GameObject Emetteur2; GameObject Emetteur3; GameObject Emetteur4;
    GameObject Emetteur5; GameObject Emetteur6; GameObject Emetteur7; GameObject Emetteur8;
    GameObject Emetteur9; GameObject Emetteur10; GameObject Emetteur11; GameObject Emetteur12;

    GameObject controleur;
    public bool recepteurActif = false;

    public bool Cyan = false;       public bool Jaune = false;      public bool Magenta = false;
    public bool Violet = false;     public bool Orange = false;     public bool Vert = false;
    public bool Soufre = false;     public bool Safran = false;     public bool Grenat = false;
    public bool Capucine = false;   public bool Campanule = false;  public bool Turquoise = false;

    public bool Cyan2 = false;      public bool Jaune2 = false;     public bool Magenta2 = false;
    public bool Violet2 = false;    public bool Orange2 = false;    public bool Vert2 = false;
    public bool Soufre2 = false;    public bool Safran2 = false;    public bool Grenat2 = false;
    public bool Capucine2 = false;  public bool Campanule2 = false; public bool Turquoise2 = false;

    public bool cat1 = false;
    public bool cat2 = false;
    public bool cat3 = false;

    public bool Black = false;
    void Start()
    {
        render = GetComponent<SpriteRenderer>();
        controleur = GameObject.Find("Controleur");
        Emetteur1 = GameObject.Find("Emetteur1");   Emetteur2 = GameObject.Find("Emetteur2");   Emetteur3 = GameObject.Find("Emetteur3");
        Emetteur4 = GameObject.Find("Emetteur4");   Emetteur5 = GameObject.Find("Emetteur5");   Emetteur6 = GameObject.Find("Emetteur6");
        Emetteur7 = GameObject.Find("Emetteur7");   Emetteur8 = GameObject.Find("Emetteur8");   Emetteur9 = GameObject.Find("Emetteur9");
        Emetteur10 = GameObject.Find("Emetteur10"); Emetteur11 = GameObject.Find("Emetteur11"); Emetteur12 = GameObject.Find("Emetteur12");

    }
    void Update()
    {
        if (Jaune == false &&
        Cyan == false &&
        Magenta == false &&
        Vert == false &&
        Violet == false &&
        Orange == false &&
        Soufre == false &&
        Safran == false &&
        Grenat == false &&
        Capucine == false &&
        Campanule == false &&
        Turquoise == false)
        {
            Black = false;
            render.color = new Color(1, 1, 1, 1);
            recepteurActif = false;
        }
        else recepteurActif = true;

        if (Cyan == true)
        {
            if (Magenta == true)
            {
                if (Cyan2 == true) { Campanule = true; }
                if (Magenta2 == true) { Grenat = true; }
                if (Magenta2 == false && Cyan2 == false) { Violet = true; }
            }
            if (Magenta == false)
            {
                if (Jaune == true)
                {
                    if (Cyan2 == true) { Turquoise = true; }
                    if (Jaune2 == true) { Soufre = true; }
                    if (Cyan2 == false && Jaune2 == false) { Vert = true; }
                }
                if (Jaune == false && Vert == true) { Turquoise = true; }
                if (Violet == true) { Campanule = true; }

            }
        }
        if (Jaune == true)
        {
            if (Magenta == true)
            {
                if (Magenta2 == true) { Capucine = true; }
                if (Jaune2 == true) { Safran = true; }
                if (Jaune2 == false && Magenta2 == false) { Orange = true; }
            }
            if (Orange == true && Magenta == false) { Safran = true; }
            if (Cyan == false && Vert == true) { Soufre = true; }
        }


        if (Magenta == true && Cyan == false && Violet == true) { Grenat = true; }
        if (Magenta == true && Jaune == false && Orange == true) { Capucine = true; }

        if (cat1 && cat2 && cat3) { Black = true; } else Black = false;




    }
    private void OnTriggerEnter2D(Collider2D col)                  // il faut ajouter un rigidbody à l'objet et il faut cocher la case "Is Trigger" dans le collider
    {
        if (col.tag == "Cyan")
        { if (Cyan == true) { Cyan2 = true; } else Cyan = true; cat1 = true; }

        if (col.tag == "Magenta")
        { if (Magenta == true) { Magenta2 = true; } else Magenta = true; cat2 = true; }

        if (col.tag == "Jaune")
        { if (Jaune == true) { Jaune2 = true; } else Jaune = true; cat3 = true; }

        if (col.tag == "Vert")
        { if (Vert == true) { Vert2 = true; } else Vert = true; cat1 = true; cat3 = true; }

        if (col.tag == "Violet")
        { if (Violet == true) { Violet2 = true; } else Violet = true; cat1 = true; cat2 = true; }

        if (col.tag == "Orange")
        { if (Orange == true) { Orange2 = true; } else Orange = true; cat2 = true; cat3 = true; }

        if (col.tag == "Soufre")
        { if (Soufre == true) { Soufre2 = true; } else Soufre = true; cat1 = true; cat3 = true; }

        if (col.tag == "Turquoise")
        { if (Turquoise == true) { Turquoise2 = true; } else Turquoise = true; cat1 = true; cat3 = true; }

        if (col.tag == "Campanule")
        { if (Campanule == true) { Campanule2 = true; } else Campanule = true; cat1 = true; cat2 = true; }

        if (col.tag == "Grenat")
        { if (Grenat == true) { Grenat2 = true; } else Grenat = true; cat1 = true; cat2 = true; }

        if (col.tag == "Capucine")
        { if (Capucine == true) { Capucine2 = true; } else Capucine = true; cat2 = true; cat3 = true; }

        if (col.tag == "Safran")
        { if (Safran == true) { Safran2 = true; } else Safran = true; cat2 = true; cat3 = true; }


    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "Cyan")
        {
            if (Cyan2 == true)
            { Cyan2 = false; Campanule = false; Turquoise = false; }
            else { Cyan = false; Violet = false; Vert = false; Soufre = false; Grenat = false; }
            if (Campanule == true) { Campanule = false; Violet = true; }
            if (Turquoise == true) { Turquoise = false; Vert = true; }

            if (!Cyan && !Violet && !Vert && !Campanule && !Turquoise)
            { cat1 = false; }

        }
        if (col.tag == "Magenta")
        {
            if (Magenta2 == true)
            { Magenta2 = false; Capucine = false; Grenat = false; }
            else { Magenta = false; Violet = false; Orange = false; Safran = false; Campanule = false; }

            if (Grenat == true) { Grenat = false; Violet = true; }
            if (Capucine == true) { Capucine = true; Orange = true; }

            if (!Magenta && !Violet && !Orange && !Grenat && !Capucine)
            { cat2 = false; }
        }
        if (col.tag == "Jaune")
        {
            if (Jaune2 == true)
            { Jaune2 = false; Soufre = false; Safran = false; }
            else { Jaune = false; Vert = false; Orange = false; Capucine = false; Turquoise = false; }

            if (Soufre == true) { Soufre = false; Vert = true; }
            if (Safran == true) { Safran = false; Orange = true; }

            if (!Jaune && !Vert && !Orange && !Soufre && !Safran)
            { cat3 = false; }
        }
        if (col.tag == "Orange")
        {
            Orange = false; Safran = false; Capucine = false;

            if (!Jaune && !Vert && !Orange && !Soufre && !Safran)
            { cat3 = false; }
            if (!Magenta && !Violet && !Orange && !Grenat && !Capucine)
            { cat2 = false; }
        }
        if (col.tag == "Violet")
        {
            Violet = false; Grenat = false; Campanule = false;

            if (!Cyan && !Violet && !Vert && !Campanule && !Turquoise)
            { cat1 = false; }
            if (!Magenta && !Violet && !Orange && !Grenat && !Capucine)
            { cat2 = false; }
        }
        if (col.tag == "Vert")
        {
            Vert = false; Turquoise = false; Soufre = false;
            if (!Cyan && !Violet && !Vert && !Campanule && !Turquoise)
            { cat1 = false; }
            if (!Jaune && !Vert && !Orange && !Soufre && !Safran)
            { cat3 = false; }
        }

        if (col.tag == "Soufre")
        {
            Soufre = false;
            if (!Cyan && !Violet && !Vert && !Campanule && !Turquoise)
            { cat1 = false; }
            if (!Jaune && !Vert && !Orange && !Soufre && !Safran)
            { cat3 = false; }
        }
        if (col.tag == "Safran")
        {
            Safran = false;
            if (!Jaune && !Vert && !Orange && !Soufre && !Safran)
            { cat3 = false; }
            if (!Magenta && !Violet && !Orange && !Grenat && !Capucine)
            { cat2 = false; }
        }
        if (col.tag == "Grenat")
        {
            Grenat = false;
            if (!Cyan && !Violet && !Vert && !Campanule && !Turquoise)
            { cat1 = false; }
            if (!Magenta && !Violet && !Orange && !Grenat && !Capucine)
            { cat2 = false; }
        }
        if (col.tag == "Capucine")
        {
            Capucine = false;

            if (!Magenta && !Violet && !Orange && !Grenat && !Capucine)
            { cat2 = false; }
            if (!Jaune && !Vert && !Orange && !Soufre && !Safran)
            { cat3 = false; }
        }
        if (col.tag == "Campanule")
        {
            Campanule = false;
            if (!Cyan && !Violet && !Vert && !Campanule && !Turquoise)
            { cat1 = false; }
            if (!Magenta && !Violet && !Orange && !Grenat && !Capucine)
            { cat2 = false; }
        }
        if (col.tag == "Turquoise")
        {
            Turquoise = false;
            if (!Cyan && !Violet && !Vert && !Campanule && !Turquoise)
            { cat1 = false; }
            if (!Jaune && !Vert && !Orange && !Soufre && !Safran)
            { cat3 = false; }

        }
        if (col.tag == "Player")
        {
            toutEstFaux();
        }
        if (col)
            switch (gameObject.name)
            {
                case ("Recepteur3"):
                    {
                        if (!Emetteur1.GetComponent<EmetteurManager>().CollisionAvecRecepteurN3 &&
                            !Emetteur2.GetComponent<EmetteurManager>().CollisionAvecRecepteurN3 &&
                            !Emetteur3.GetComponent<EmetteurManager>().CollisionAvecRecepteurN3 &&
                            !Emetteur4.GetComponent<EmetteurManager>().CollisionAvecRecepteurN3 &&
                            !Emetteur5.GetComponent<EmetteurManager>().CollisionAvecRecepteurN3 &&
                            !Emetteur6.GetComponent<EmetteurManager>().CollisionAvecRecepteurN3 &&
                            !Emetteur7.GetComponent<EmetteurManager>().CollisionAvecRecepteurN3 &&
                            !Emetteur8.GetComponent<EmetteurManager>().CollisionAvecRecepteurN3 &&
                            !Emetteur9.GetComponent<EmetteurManager>().CollisionAvecRecepteurN3 &&
                            !Emetteur10.GetComponent<EmetteurManager>().CollisionAvecRecepteurN3)
                        {
                            toutEstFaux();
                        }
                    }
                    break;
                case ("Recepteur4"):
                    {
                        if (!Emetteur1.GetComponent<EmetteurManager>().CollisionAvecRecepteurN4 &&
                            !Emetteur2.GetComponent<EmetteurManager>().CollisionAvecRecepteurN4 &&
                            !Emetteur3.GetComponent<EmetteurManager>().CollisionAvecRecepteurN4 &&
                            !Emetteur4.GetComponent<EmetteurManager>().CollisionAvecRecepteurN4 &&
                            !Emetteur5.GetComponent<EmetteurManager>().CollisionAvecRecepteurN4 &&
                            !Emetteur6.GetComponent<EmetteurManager>().CollisionAvecRecepteurN4 &&
                            !Emetteur7.GetComponent<EmetteurManager>().CollisionAvecRecepteurN4 &&
                            !Emetteur8.GetComponent<EmetteurManager>().CollisionAvecRecepteurN4 &&
                            !Emetteur9.GetComponent<EmetteurManager>().CollisionAvecRecepteurN4 &&
                            !Emetteur10.GetComponent<EmetteurManager>().CollisionAvecRecepteurN4)
                        {
                            toutEstFaux();
                        }
                    }
                    break;
                case ("Recepteur5"):
                    {
                        if (!Emetteur1.GetComponent<EmetteurManager>().CollisionAvecRecepteurN5 &&
                            !Emetteur2.GetComponent<EmetteurManager>().CollisionAvecRecepteurN5 &&
                            !Emetteur3.GetComponent<EmetteurManager>().CollisionAvecRecepteurN5 &&
                            !Emetteur4.GetComponent<EmetteurManager>().CollisionAvecRecepteurN5 &&
                            !Emetteur5.GetComponent<EmetteurManager>().CollisionAvecRecepteurN5 &&
                            !Emetteur6.GetComponent<EmetteurManager>().CollisionAvecRecepteurN5 &&
                            !Emetteur7.GetComponent<EmetteurManager>().CollisionAvecRecepteurN5 &&
                            !Emetteur8.GetComponent<EmetteurManager>().CollisionAvecRecepteurN5 &&
                            !Emetteur9.GetComponent<EmetteurManager>().CollisionAvecRecepteurN5 &&
                            !Emetteur10.GetComponent<EmetteurManager>().CollisionAvecRecepteurN5)
                        {
                            toutEstFaux();
                        }
                    }
                    break;
                case ("Recepteur6"):
                    {
                        if (!Emetteur1.GetComponent<EmetteurManager>().CollisionAvecRecepteurN6 &&
                            !Emetteur2.GetComponent<EmetteurManager>().CollisionAvecRecepteurN6 &&
                            !Emetteur3.GetComponent<EmetteurManager>().CollisionAvecRecepteurN6 &&
                            !Emetteur4.GetComponent<EmetteurManager>().CollisionAvecRecepteurN6 &&
                            !Emetteur5.GetComponent<EmetteurManager>().CollisionAvecRecepteurN6 &&
                            !Emetteur6.GetComponent<EmetteurManager>().CollisionAvecRecepteurN6 &&
                            !Emetteur7.GetComponent<EmetteurManager>().CollisionAvecRecepteurN6 &&
                            !Emetteur8.GetComponent<EmetteurManager>().CollisionAvecRecepteurN6 &&
                            !Emetteur9.GetComponent<EmetteurManager>().CollisionAvecRecepteurN6 &&
                            !Emetteur10.GetComponent<EmetteurManager>().CollisionAvecRecepteurN6)
                        {
                            toutEstFaux();
                        }
                    }
                    break;
                case ("Recepteur7"):
                    {
                        if (!Emetteur1.GetComponent<EmetteurManager>().CollisionAvecRecepteurN7 &&
                            !Emetteur2.GetComponent<EmetteurManager>().CollisionAvecRecepteurN7 &&
                            !Emetteur3.GetComponent<EmetteurManager>().CollisionAvecRecepteurN7 &&
                            !Emetteur4.GetComponent<EmetteurManager>().CollisionAvecRecepteurN7 &&
                            !Emetteur5.GetComponent<EmetteurManager>().CollisionAvecRecepteurN7 &&
                            !Emetteur6.GetComponent<EmetteurManager>().CollisionAvecRecepteurN7 &&
                            !Emetteur7.GetComponent<EmetteurManager>().CollisionAvecRecepteurN7 &&
                            !Emetteur8.GetComponent<EmetteurManager>().CollisionAvecRecepteurN7 &&
                            !Emetteur9.GetComponent<EmetteurManager>().CollisionAvecRecepteurN7 &&
                            !Emetteur10.GetComponent<EmetteurManager>().CollisionAvecRecepteurN7)
                        {
                            toutEstFaux();
                        }
                    }
                    break;
                case ("Recepteur8"):
                    {
                        if (!Emetteur1.GetComponent<EmetteurManager>().CollisionAvecRecepteurN8 &&
                            !Emetteur2.GetComponent<EmetteurManager>().CollisionAvecRecepteurN8 &&
                            !Emetteur3.GetComponent<EmetteurManager>().CollisionAvecRecepteurN8 &&
                            !Emetteur4.GetComponent<EmetteurManager>().CollisionAvecRecepteurN8 &&
                            !Emetteur5.GetComponent<EmetteurManager>().CollisionAvecRecepteurN8 &&
                            !Emetteur6.GetComponent<EmetteurManager>().CollisionAvecRecepteurN8 &&
                            !Emetteur7.GetComponent<EmetteurManager>().CollisionAvecRecepteurN8 &&
                            !Emetteur8.GetComponent<EmetteurManager>().CollisionAvecRecepteurN8 &&
                            !Emetteur9.GetComponent<EmetteurManager>().CollisionAvecRecepteurN8 &&
                            !Emetteur10.GetComponent<EmetteurManager>().CollisionAvecRecepteurN8)
                        {
                            toutEstFaux();
                        }
                    }
                    break;
            }
    }
    private void toutEstFaux ()
    {
        Cyan = false; Jaune = false; Magenta = false;
        Violet = false; Orange = false; Vert = false;
        Soufre = false; Safran = false; Grenat = false;
        Capucine = false; Campanule = false; Turquoise = false;

        Cyan2 = false; Jaune2 = false; Magenta2 = false;
        Violet2 = false; Orange2 = false; Vert2 = false;
        Soufre2 = false; Safran2 = false; Grenat2 = false;
        Capucine2 = false; Campanule2 = false; Turquoise2 = false;

        cat1 = false;
        cat2 = false;
        cat3 = false;

        Black = false;
    }
}