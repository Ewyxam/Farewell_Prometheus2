using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventAnim : MonoBehaviour
{
    public GameObject launchscan;
    public void EndAnim()
    {
        gameObject.GetComponent<Animator>().SetBool("load", false);
        launchscan.GetComponent<DescriptionManager>().LaunchScan();
    }
    
}
