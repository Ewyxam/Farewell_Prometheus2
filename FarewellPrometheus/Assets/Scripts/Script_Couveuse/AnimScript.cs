using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimScript : MonoBehaviour
/* Ce script doit être attacher aux cercles qui vont pivoter
   Chaque cercle doit être équipé d'un component "ANIMATOR"
*/
{
    Animator anim;

    /* Bool autorisant le passage à l'animation suivante, ils sont
       en permence FALSE sauf si on appuis sur le bouton, là ils
       deviennent TRUE pour 1 frame ce qui permet de déclancher l'animation
    */
    private bool bouton_001 = false;
    private bool bouton_002 = false;
    private bool bouton_003 = false;
    private bool bouton_004 = false;
    private bool bouton_005 = false;
    private bool bouton_006 = false;



    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        switch (gameObject.name)
        {
            case ("Tuyau01"):
                ///////////////////////////////////////////// Mouvement ALLER du Cercle N°1
                if (bouton_001 == true || bouton_003 == true)
                {
                    anim.SetBool("C1_ALLER", true);
                }
                else anim.SetBool("C1_ALLER", false);
                ///////////////////////////////////////////// Mouvement RETOUR du Cercle N°1
                if (bouton_004 == true || bouton_006 == true)
                {
                    anim.SetBool("C1_RETOUR", true);
                }
                else anim.SetBool("C1_RETOUR", false);

                break;
            case ("Tuyau02"):
                ///////////////////////////////////////////// Mouvement ALLER du Cercle N°2
                if (bouton_003 == true || bouton_004 == true || bouton_005 == true)
                {
                    anim.SetBool("C2_ALLER", true);
                }
                else anim.SetBool("C2_ALLER", false);
                ///////////////////////////////////////////// Mouvement RETOUR du Cercle N°2
                if (bouton_001 == true || bouton_002 == true || bouton_006 == true)
                {
                    anim.SetBool("C2_RETOUR", true);
                }
                else anim.SetBool("C2_RETOUR", false);

                break;
            case ("Tuyau03"):

                ///////////////////////////////////////////// Mouvement ALLER du Cercle N°3
                if (bouton_002 == true)
                {
                    anim.SetBool("C3_ALLER", true);
                }
                else anim.SetBool("C3_ALLER", false);

                ///////////////////////////////////////////// Mouvement RETOUR du Cercle N°3
                if (bouton_005 == true)
                {
                    anim.SetBool("C3_RETOUR", true);
                }
                else anim.SetBool("C3_RETOUR", false);

                break;


        }









        ///////////////////////////////////////////// Remet sur FALSE les autorisations d'animation
        bouton_001 = false;
        bouton_002 = false;
        bouton_003 = false;
        bouton_004 = false;
        bouton_005 = false;
        bouton_006 = false;



    }
    /* il y a une fonction par bouton, chaque bouton permet de transformer le bool qui lui et attribué en TRUE
     Dans UNITY:
     Chaque boutons a 3 conditions "ON CLICK ()" une par cercle
     Dans ses conditions, on ajoute la fonction "BoutonX_ON()" avec X qui correspond au botton que l'on programme
    */
    public void Bouton1_ON()
    {
        bouton_001 = true;
    }
    public void Bouton2_ON()
    {
        bouton_002 = true;
    }
    public void Bouton3_ON()
    {
        bouton_003 = true;
    }
    public void Bouton4_ON()
    {
        bouton_004 = true;
    }
    public void Bouton5_ON()
    {
        bouton_005 = true;
    }
    public void Bouton6_ON()
    {
        bouton_006 = true;
    }
}
/*
/////////////////////////////////////////////        
if (bouton_001 == true)
{
    anim.SetBool("C2_ALLER", true);
    anim.SetBool("C3_RETOUR", true);
}
else
{
    anim.SetBool("C2_ALLER", false);
    anim.SetBool("C3_RETOUR", false);
}
if (bouton_004 == true)
{
    anim.SetBool("C2_RETOUR", true);
    anim.SetBool("C3_ALLER", true);
}
else
{
    anim.SetBool("C2_RETOUR", false);
    anim.SetBool("C3_ALLER", false);
}

/////////////////////////////////////////////
if (bouton_002 == true)
{
    anim.SetBool("C1_ALLER", true);
    anim.SetBool("C3_ALLER", true);
}
else
{
    anim.SetBool("C1_ALLER", false);
    anim.SetBool("C3_ALLER", false);
}
if (bouton_005 == true)
{
    anim.SetBool("C1_RETOUR", true);
    anim.SetBool("C3_RETOUR", true);
}
else
{
    anim.SetBool("C1_RETOUR", false);
    anim.SetBool("C3_RETOUR", false);
}

/////////////////////////////////////////////
if (bouton_003 == true)
{
    anim.SetBool("C1_RETOUR", true);
    anim.SetBool("C2_RETOUR", true);
}
else
{
    anim.SetBool("C1_RETOUR", false);
    anim.SetBool("C2_RETOUR", false);
}

if (bouton_006 == true)
{
    anim.SetBool("C1_ALLER", true);
    anim.SetBool("C2_ALLER", true);
}
else
{
    anim.SetBool("C1_ALLER", false);
    anim.SetBool("C2_ALLER", false);
}
*/
/*
if (Input.GetKey(KeyCode.D))        // Cercle_002 RETOUR
{
}
if (Input.GetKey(KeyCode.X))        // Cercle_003 ALLER
{
}
if (Input.GetKey(KeyCode.C))        // Cercle_003 RETOUR
{
    anim.SetBool("C2_ALLER", true);
    anim.SetBool("C3_RETOUR", true);
    PRESS_C = true;
} else PRESS_C = false;

if (PRESS_Z == false && PRESS_C == false)
{
    OFF();
}
*/

/*
   //Cercle 1
   if (Input.GetKey(KeyCode.Z))
   {
       anim.SetBool("C1_ALLER", true);
       anim.SetBool("C3_RETOUR", true);

       //            Debug.LogError("C1_Aller = true");
   }
   else
   {
       anim.SetBool("C1_ALLER", false);
//           Debug.LogError("C1_Aller = false");

   }
   if (Input.GetKey(KeyCode.E))
   {
       anim.SetBool("C1_RETOUR", true);
       anim.SetBool("C2_RETOUR", true);

       //            Debug.LogError("C1_Retour = true");
   }
   else
   {

       anim.SetBool("C1_RETOUR", false);
//            Debug.LogError("C1_Retour = false");
   }

   // Cercle 2

   if (Input.GetKey(KeyCode.S))
   {
       anim.SetBool("C2_ALLER", true);
//            Debug.LogError("C2_Aller = true");
   }
   else
   {
       anim.SetBool("C2_ALLER", false);
//            Debug.LogError("C2_Aller = false");
   }
   if (Input.GetKey(KeyCode.D))
   {
       anim.SetBool("C2_RETOUR", true);
//            Debug.LogError(" C2_Retour = true");
   }
   else
   {
       if (Input.GetKeyUp(KeyCode.E))
       {
           anim.SetBool("C2_RETOUR", false);
       }
//           Debug.LogError("C2_Retour = false");
   }

   //Cercle 3

   if (Input.GetKey(KeyCode.X))
   {
       anim.SetBool("C3_ALLER", true);
//            Debug.LogError("C3_Aller = true");
   }
   else
   {
       anim.SetBool("C3_ALLER", false);
//           Debug.LogError("C3_Aller = false");
   }
   if (Input.GetKey(KeyCode.C))
   {
       anim.SetBool("C3_RETOUR", true);
//            Debug.LogError("C3_Retour = true");
   }
   else
   {
       if (Input.GetKeyUp(KeyCode.Z))
       {
           anim.SetBool("C3_RETOUR", false);
       }
//           Debug.LogError("C3_Retour = false");
   }

if (Input.GetKeyDown(KeyCode.Z))
{
   aller = true;
   Debug.LogError("Aller " + aller);
   if (aller == true)
   {

       if (Xen >= 0)
       {
           Xen = Xen + 1;
       }
       if (Xne <= 0)
       {
           Xne = Xne - 1;
       }

       anim.SetInteger("NEX", Xen);

       Debug.LogError("Z is press Xen = " + Xen);
       Debug.LogError("Z is press Xne = " + Xne);
   }   
}


if (Input.GetKeyDown(KeyCode.E))
{
   aller = false;
   Debug.LogError("Aller " + aller);
   if (aller == false)
   {
       if (Xen >= 0)
       {
           Xen = Xen - 1;
       }


       if (Xne <= 0)
       {
           Xne = Xne + 1;
       }

       anim.SetInteger("NEX", Xne);

   }
   Debug.LogError("E is press Xen = " + Xen);
   Debug.LogError("E is press Xne = " + Xne);
   }
*/


/*        if (anim.GetCurrentAnimatorStateInfo(0).IsName("IDLE"))
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                anim.SetTrigger("Antihoraire1");
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                anim.SetTrigger("horaire1");
            }
        }
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("IDLE"))
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                anim.SetTrigger("Antihoraire2");
            }
        }

}
*/
