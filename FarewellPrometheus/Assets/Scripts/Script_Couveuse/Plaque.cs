using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plaque : MonoBehaviour
{
    // Start is called before the first frame update

    public void AnimPlaque()
    {
        GetComponent<Animator>().SetBool("ActivationPlaque", true);
    }
}
