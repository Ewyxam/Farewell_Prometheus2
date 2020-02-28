using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosHier : MonoBehaviour
{
    // Start is called before the first frame update
    Taille taille;


    private void Start()
    {
        taille = GameObject.Find("Panneau").GetComponent<Taille>();
    }
    public void PosiSlotSuivant()
    {
        gameObject.transform.SetSiblingIndex(8);
    }
    public void PosiSlotDernier()
    {
        gameObject.transform.SetAsLastSibling();
    }
}
