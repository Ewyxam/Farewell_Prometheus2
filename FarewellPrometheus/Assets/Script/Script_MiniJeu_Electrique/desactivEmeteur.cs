using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class desactivEmeteur : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject Emetteur1;                   GameObject Emetteur2;                    GameObject Emetteur3;                      GameObject Emetteur4;
    GameObject Emetteur5;                   GameObject Emetteur6;                    GameObject Emetteur7;                      GameObject Emetteur8;
    GameObject Emetteur9;                   GameObject Emetteur10;                   GameObject Emetteur11;                     GameObject Emetteur12;

    public bool Emetteur1estBloque;         public bool Emetteur2estBloque;          public bool Emetteur3estBloque;            public bool Emetteur4estBloque;
    public bool Emetteur5estBloque;         public bool Emetteur6estBloque;          public bool Emetteur7estBloque;            public bool Emetteur8estBloque;
    public bool Emetteur9estBloque;         public bool Emetteur10estBloque;

    private bool Emetteur1_ON;              private bool Emetteur2_ON;               private bool Emetteur3_ON;                 private bool Emetteur4_ON;
    private bool Emetteur5_ON;              private bool Emetteur6_ON;               private bool Emetteur7_ON;                 private bool Emetteur8_ON;
    private bool Emetteur9_ON;              private bool Emetteur10_ON;              private bool Emetteur11_ON;                private bool Emetteur12_ON;

    public bool Emetteur1_Verrou1 = false;  public bool Emetteur1_Verrou2 = false;   public bool Emetteur1_Verrou3 = false;     public bool Emetteur1_Verrou4 = false; 
    public bool Emetteur2_Verrou1 = false;  public bool Emetteur2_Verrou2 = false;   public bool Emetteur2_Verrou3 = false;     public bool Emetteur2_Verrou4 = false; 
    public bool Emetteur3_Verrou1 = false;  public bool Emetteur3_Verrou2 = false;   public bool Emetteur3_Verrou3 = false;     public bool Emetteur3_Verrou4 = false;
    public bool Emetteur4_Verrou1 = false;  public bool Emetteur4_Verrou2 = false;   public bool Emetteur4_Verrou3 = false;     public bool Emetteur4_Verrou4 = false;
    public bool Emetteur5_Verrou1 = false;  public bool Emetteur5_Verrou2 = false;   public bool Emetteur5_Verrou3 = false;     public bool Emetteur5_Verrou4 = false;
    public bool Emetteur6_Verrou1 = false;  public bool Emetteur6_Verrou2 = false;   public bool Emetteur6_Verrou3 = false;     public bool Emetteur6_Verrou4 = false;
    public bool Emetteur7_Verrou1 = false;  public bool Emetteur7_Verrou2 = false;
    public bool Emetteur8_Verrou1 = false;  public bool Emetteur8_Verrou2 = false;
    public bool Emetteur9_Verrou1 = false;  public bool Emetteur9_Verrou2 = false;
    public bool Emetteur10_Verrou1 = false; public bool Emetteur10_Verrou2 = false;

    private void Update()
    {
        Emetteur1 = GameObject.Find("Emetteur1");       Emetteur2 = GameObject.Find("Emetteur2");       Emetteur3 = GameObject.Find("Emetteur3");
        Emetteur4 = GameObject.Find("Emetteur4");       Emetteur5 = GameObject.Find("Emetteur5");       Emetteur6 = GameObject.Find("Emetteur6");
        Emetteur7 = GameObject.Find("Emetteur7");       Emetteur8 = GameObject.Find("Emetteur8");       Emetteur9 = GameObject.Find("Emetteur9");
        Emetteur10 = GameObject.Find("Emetteur10");     Emetteur11 = GameObject.Find("Emetteur11");     Emetteur12 = GameObject.Find("Emetteur12");

        Emetteur1_ON = Emetteur1.GetComponent<EmetteurManager>().EmetteurON;        Emetteur2_ON = Emetteur2.GetComponent<EmetteurManager>().EmetteurON;
        Emetteur3_ON = Emetteur3.GetComponent<EmetteurManager>().EmetteurON;        Emetteur4_ON = Emetteur4.GetComponent<EmetteurManager>().EmetteurON;
        Emetteur5_ON = Emetteur5.GetComponent<EmetteurManager>().EmetteurON;        Emetteur6_ON = Emetteur6.GetComponent<EmetteurManager>().EmetteurON;
        Emetteur7_ON = Emetteur7.GetComponent<EmetteurManager>().EmetteurON;        Emetteur8_ON = Emetteur8.GetComponent<EmetteurManager>().EmetteurON;
        Emetteur9_ON = Emetteur9.GetComponent<EmetteurManager>().EmetteurON;        Emetteur10_ON = Emetteur10.GetComponent<EmetteurManager>().EmetteurON;
        Emetteur11_ON = Emetteur11.GetComponent<EmetteurManager>().EmetteurON;      Emetteur12_ON = Emetteur11.GetComponent<EmetteurManager>().EmetteurON;

        desactiveDND();
    }


    public void desactiveDND()
    {

        /////////////////////EMETTEUR1///////////////////////////////////////////////////////////////////////////////////////////////////
        if (!Emetteur1_ON)
        {
            Emetteur1estBloque = false;
            Emetteur1_Verrou1 = false;
            Emetteur1_Verrou2 = false;
            Emetteur1_Verrou3 = false;
            Emetteur1_Verrou4 = false;
        }
        if (!Emetteur1_Verrou1 && !Emetteur1_Verrou2 && !Emetteur1_Verrou3 && !Emetteur1_Verrou4)
        {
            Emetteur1estBloque = false;
        }

        else Emetteur1estBloque = true;
        ////////////////////////////////////
        if (Emetteur1.GetComponent<EmetteurManager>().CollisionAvecRecepteurN1)
        {
            if (Emetteur7_ON || Emetteur8_ON)
            { Emetteur1_Verrou1 = true; }
            else Emetteur1_Verrou1 = false;
        }
        if (Emetteur1.GetComponent<EmetteurManager>().CollisionAvecRecepteurN2)
        {
            if (Emetteur9_ON || Emetteur10_ON)
            { Emetteur1_Verrou2 = true; }
            else Emetteur1_Verrou2 = false;
        }
        if (Emetteur1.GetComponent<EmetteurManager>().CollisionAvecRecepteurN3)
        {
            if (Emetteur11_ON)
            { Emetteur1_Verrou3 = true; }
            else Emetteur1_Verrou3 = false;
        }
        if (Emetteur1.GetComponent<EmetteurManager>().CollisionAvecRecepteurN4)
        {
            if (Emetteur12_ON)
            { Emetteur1_Verrou4 = true; }
            else Emetteur1_Verrou4 = false;
        }
        /////////////////////EMETTEUR2///////////////////////////////////////////////////////////////////////////////////////////////////
        if (!Emetteur2_ON)
        {
            Emetteur2estBloque = false;
            Emetteur2_Verrou1 = false;
            Emetteur2_Verrou2 = false;
            Emetteur2_Verrou3 = false;
            Emetteur2_Verrou4 = false;
        }
        if (!Emetteur2_Verrou1 && !Emetteur2_Verrou2 && !Emetteur2_Verrou3 && !Emetteur2_Verrou4)
        {
            Emetteur2estBloque = false;
        }

        else Emetteur2estBloque = true;
        ////////////////////////////////////
        if (Emetteur2.GetComponent<EmetteurManager>().CollisionAvecRecepteurN1)
        {
            if (Emetteur7_ON || Emetteur8_ON)
            { Emetteur2_Verrou1 = true; }
            else Emetteur2_Verrou1 = false;
        }
        if (Emetteur2.GetComponent<EmetteurManager>().CollisionAvecRecepteurN2)
        {
            if (Emetteur9_ON || Emetteur10_ON)
            { Emetteur2_Verrou2 = true; }
            else Emetteur2_Verrou2 = false;
        }
        if (Emetteur2.GetComponent<EmetteurManager>().CollisionAvecRecepteurN3)
        {
            if (Emetteur11_ON)
            { Emetteur2_Verrou3 = true; }
            else Emetteur2_Verrou3 = false;
        }
        if (Emetteur2.GetComponent<EmetteurManager>().CollisionAvecRecepteurN4)
        {
            if (Emetteur12_ON)
            { Emetteur2_Verrou4 = true; }
            else Emetteur2_Verrou4 = false;
        }

        //////////////////////////////EMETTEUR3//////////////////////////////////////////////////////////////////////////////////////////
        if (!Emetteur3_ON)
        {
            Emetteur3estBloque = false;
            Emetteur3_Verrou1 = false;
            Emetteur3_Verrou2 = false;
            Emetteur3_Verrou3 = false;
            Emetteur3_Verrou4 = false;
        }
        if (!Emetteur3_Verrou1 && !Emetteur3_Verrou2 && !Emetteur3_Verrou3 && !Emetteur3_Verrou4)
        {
            Emetteur3estBloque = false;
        }

        else Emetteur3estBloque = true;
        ////////////////////////////////////
        if (Emetteur3.GetComponent<EmetteurManager>().CollisionAvecRecepteurN1)
        {
            if (Emetteur7_ON || Emetteur8_ON)
            { Emetteur3_Verrou1 = true; }
            else Emetteur3_Verrou1 = false;
        }
        if (Emetteur3.GetComponent<EmetteurManager>().CollisionAvecRecepteurN2)
        {
            if (Emetteur9_ON || Emetteur10_ON)
            { Emetteur3_Verrou2 = true; }
            else Emetteur3_Verrou2 = false;
        }
        if (Emetteur3.GetComponent<EmetteurManager>().CollisionAvecRecepteurN3)
        {
            if (Emetteur11_ON)
            { Emetteur3_Verrou3 = true; }
            else Emetteur3_Verrou3 = false;
        }
        if (Emetteur3.GetComponent<EmetteurManager>().CollisionAvecRecepteurN4)
        {
            if (Emetteur12_ON)
            { Emetteur3_Verrou4 = true; }
            else Emetteur3_Verrou4 = false;
        }
        //////////////////////////////EMETTEUR4//////////////////////////////////////////////////////////////////////////////////////////
        if (!Emetteur4_ON)
        {
            Emetteur4estBloque = false;
            Emetteur4_Verrou1 = false;
            Emetteur4_Verrou2 = false;
            Emetteur4_Verrou3 = false;
            Emetteur4_Verrou4 = false;
        }
        if (!Emetteur4_Verrou1 && !Emetteur4_Verrou2 && !Emetteur4_Verrou3 && !Emetteur4_Verrou4)
        {
            Emetteur4estBloque = false;
        }

        else Emetteur4estBloque = true;
        ////////////////////////////////////
        if (Emetteur4.GetComponent<EmetteurManager>().CollisionAvecRecepteurN1)
        {
            if (Emetteur7_ON || Emetteur8_ON)
            { Emetteur4_Verrou1 = true; }
            else Emetteur4_Verrou1 = false;
        }
        if (Emetteur4.GetComponent<EmetteurManager>().CollisionAvecRecepteurN2)
        {
            if (Emetteur9_ON || Emetteur10_ON)
            { Emetteur4_Verrou2 = true; }
            else Emetteur4_Verrou2 = false;
        }
        if (Emetteur4.GetComponent<EmetteurManager>().CollisionAvecRecepteurN3)
        {
            if (Emetteur11_ON)
            { Emetteur4_Verrou3 = true; }
            else Emetteur4_Verrou3 = false;
        }
        if (Emetteur4.GetComponent<EmetteurManager>().CollisionAvecRecepteurN4)
        {
            if (Emetteur12_ON)
            { Emetteur4_Verrou4 = true; }
            else Emetteur4_Verrou4 = false;
        }

        //////////////////////////////EMETTEUR5//////////////////////////////////////////////////////////////////////////////////////////
        if (!Emetteur5_ON)
        {
            Emetteur5estBloque = false;
            Emetteur5_Verrou1 = false;
            Emetteur5_Verrou2 = false;
            Emetteur5_Verrou3 = false;
            Emetteur5_Verrou4 = false;
        }
        if (!Emetteur5_Verrou1 && !Emetteur5_Verrou2 && !Emetteur5_Verrou3 && !Emetteur5_Verrou4)
        {
            Emetteur5estBloque = false;
        }

        else Emetteur5estBloque = true;
        ////////////////////////////////////
        if (Emetteur5.GetComponent<EmetteurManager>().CollisionAvecRecepteurN1)
        {
            if (Emetteur7_ON || Emetteur8_ON)
            { Emetteur5_Verrou1 = true; }
            else Emetteur5_Verrou1 = false;
        }
        if (Emetteur5.GetComponent<EmetteurManager>().CollisionAvecRecepteurN2)
        {
            if (Emetteur9_ON || Emetteur10_ON)
            { Emetteur5_Verrou2 = true; }
            else Emetteur5_Verrou2 = false;
        }
        if (Emetteur5.GetComponent<EmetteurManager>().CollisionAvecRecepteurN3)
        {
            if (Emetteur11_ON)
            { Emetteur5_Verrou3 = true; }
            else Emetteur5_Verrou3 = false;
        }
        if (Emetteur5.GetComponent<EmetteurManager>().CollisionAvecRecepteurN4)
        {
            if (Emetteur12_ON)
            { Emetteur5_Verrou4 = true; }
            else Emetteur5_Verrou4 = false;
        }

        //////////////////////////////EMETTEUR6//////////////////////////////////////////////////////////////////////////////////////////
        if (!Emetteur6_ON)
        {
            Emetteur6estBloque = false;
            Emetteur6_Verrou1 = false;
            Emetteur6_Verrou2 = false;
            Emetteur6_Verrou3 = false;
            Emetteur6_Verrou4 = false;
        }
        if (!Emetteur6_Verrou1 && !Emetteur6_Verrou2 && !Emetteur6_Verrou3 && !Emetteur6_Verrou4)
        {
            Emetteur6estBloque = false;
        }

        else Emetteur6estBloque = true;
        ////////////////////////////////////
        if (Emetteur6.GetComponent<EmetteurManager>().CollisionAvecRecepteurN1)
        {
            if (Emetteur7_ON || Emetteur8_ON)
            { Emetteur6_Verrou1 = true; }
            else Emetteur6_Verrou1 = false;
        }
        if (Emetteur6.GetComponent<EmetteurManager>().CollisionAvecRecepteurN2)
        {
            if (Emetteur9_ON || Emetteur10_ON)
            { Emetteur6_Verrou2 = true; }
            else Emetteur6_Verrou2 = false;
        }
        if (Emetteur6.GetComponent<EmetteurManager>().CollisionAvecRecepteurN3)
        {
            if (Emetteur11_ON)
            { Emetteur6_Verrou3 = true; }
            else Emetteur6_Verrou3 = false;
        }
        if (Emetteur6.GetComponent<EmetteurManager>().CollisionAvecRecepteurN4)
        {
            if (Emetteur12_ON)
            { Emetteur6_Verrou4 = true; }
            else Emetteur6_Verrou4 = false;
        }
        //////////////////////////////EMETTEUR7//////////////////////////////////////////////////////////////////////////////////////////
        if (!Emetteur7_ON)
        {
            Emetteur7estBloque = false;
            Emetteur7_Verrou1 = false;
            Emetteur7_Verrou2 = false;

        }
        if (!Emetteur7_Verrou1 && !Emetteur7_Verrou2)
        {
            Emetteur7estBloque = false;
        }

        else Emetteur7estBloque = true;
        ////////////////////////////////////

        if (Emetteur7.GetComponent<EmetteurManager>().CollisionAvecRecepteurN3)
        {
            if (Emetteur11_ON)
            { Emetteur7_Verrou1 = true; }
            else Emetteur7_Verrou1 = false;
        }
        if (Emetteur6.GetComponent<EmetteurManager>().CollisionAvecRecepteurN4)
        {
            if (Emetteur12_ON)
            { Emetteur7_Verrou2 = true; }
            else Emetteur7_Verrou2 = false;
        }

        //////////////////////////////EMETTEUR8//////////////////////////////////////////////////////////////////////////////////////////
        if (!Emetteur8_ON)
        {
            Emetteur8estBloque = false;
            Emetteur8_Verrou1 = false;
            Emetteur8_Verrou2 = false;

        }
        if (!Emetteur8_Verrou1 && !Emetteur8_Verrou2)
        {
            Emetteur8estBloque = false;
        }

        else Emetteur8estBloque = true;
        ////////////////////////////////////

        if (Emetteur8.GetComponent<EmetteurManager>().CollisionAvecRecepteurN3)
        {
            if (Emetteur11_ON)
            { Emetteur8_Verrou1 = true; }
            else Emetteur8_Verrou1 = false;
        }
        if (Emetteur8.GetComponent<EmetteurManager>().CollisionAvecRecepteurN4)
        {
            if (Emetteur12_ON)
            { Emetteur8_Verrou2 = true; }
            else Emetteur8_Verrou2 = false;
        }
        //////////////////////////////EMETTEUR9//////////////////////////////////////////////////////////////////////////////////////////
        if (!Emetteur9_ON)
        {
            Emetteur9estBloque = false;
            Emetteur9_Verrou1 = false;
            Emetteur9_Verrou2 = false;

        }
        if (!Emetteur9_Verrou1 && !Emetteur9_Verrou2)
        {
            Emetteur9estBloque = false;
        }

        else Emetteur9estBloque = true;
        ////////////////////////////////////

        if (Emetteur9.GetComponent<EmetteurManager>().CollisionAvecRecepteurN3)
        {
            if (Emetteur11_ON)
            { Emetteur9_Verrou1 = true; }
            else Emetteur9_Verrou1 = false;
        }
        if (Emetteur9.GetComponent<EmetteurManager>().CollisionAvecRecepteurN4)
        {
            if (Emetteur12_ON)
            { Emetteur9_Verrou2 = true; }
            else Emetteur9_Verrou2 = false;
        }

        //////////////////////////////EMETTEUR10//////////////////////////////////////////////////////////////////////////////////////////
        if (!Emetteur10_ON)
        {
            Emetteur10estBloque = false;
            Emetteur10_Verrou1 = false;
            Emetteur10_Verrou2 = false;

        }
        if (!Emetteur10_Verrou1 && !Emetteur10_Verrou2)
        {
            Emetteur10estBloque = false;
        }

        else Emetteur10estBloque = true;
        ////////////////////////////////////

        if (Emetteur10.GetComponent<EmetteurManager>().CollisionAvecRecepteurN3)
        {
            if (Emetteur11_ON)
            { Emetteur10_Verrou1 = true; }
            else Emetteur10_Verrou1 = false;
        }
        if (Emetteur10.GetComponent<EmetteurManager>().CollisionAvecRecepteurN4)
        {
            if (Emetteur10_ON)
            { Emetteur10_Verrou2 = true; }
            else Emetteur10_Verrou2 = false;
        }
    }
}
