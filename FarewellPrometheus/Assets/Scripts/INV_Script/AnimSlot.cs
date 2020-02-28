using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimSlot : MonoBehaviour
{
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void AnimationSlotON()
    {
        anim.SetBool("Slot1Anim", true);
    }
    public void AnimationSlotOFF()
    {
        anim.SetBool("Slot1Anim", false);


    }
}

