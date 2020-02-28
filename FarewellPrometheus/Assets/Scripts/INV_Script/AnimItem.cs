using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimItem : MonoBehaviour
{
    Animator anim;                                         
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void AnimationItemON()
    {
        anim.SetBool("ItemSelect", true);                   //Déclenche l'animation qui supprime l'image de l'Item dans la scène lorsqu'il a été trouvé par le joueur
    }
    public void AnimationItemOFF()
    {
        anim.SetBool("ItemSelect", false);                   //Permet de remettre l'item sur le IDLE de l'animator
    }

}
