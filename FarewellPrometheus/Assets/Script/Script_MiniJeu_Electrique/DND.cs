using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DND : MonoBehaviour                          // attacher se script à l'objet que l'on souhaite deplacer
{
    public bool canDropDND = false;                                         // pour pouvoir ou non lacher l'objet


    private void Update()
    {
        transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
        if (transform.position.z !=0)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 0);

        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "RecepteurPri" || col.tag == "RecepteurSec" || col.tag == "RecepteurTer")
        {
            canDropDND = true;
        }
    }
    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "RecepteurPri" || col.tag == "RecepteurSec" || col.tag == "RecepteurTer")
        {
            canDropDND = false;
        }
    }
}

