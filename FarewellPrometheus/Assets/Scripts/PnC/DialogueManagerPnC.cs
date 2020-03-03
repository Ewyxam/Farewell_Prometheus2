using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AK.Wwise;

public class DialogueManagerPnC : MonoBehaviour
{
    public int location;
    public bool visited;
    public string objectClicked;
    public bool cisailleInInventory;

    public void ArrivalPanelDial()
    {
        if (!visited)
        {
        if (location == 1)
            {
                AkSoundEngine.SetSwitch("Dial_PnC", "CL1_IV_02_SFX", gameObject);
                AkSoundEngine.PostEvent("Dial_PnC_Event", gameObject);
            }
        //else if location == y ; etc
        //else { ligne global }
        }
        /*else if déjà visité {
        if location == CP2 {random ligne de dial CP)
    
        */
    }

    public void GrabObjectPDial()
    {
        if (objectClicked == "Fleur puante")
        {
            if (cisailleInInventory)
            {
                AkSoundEngine.SetSwitch("Dial_PnC", "A_I", gameObject);
                AkSoundEngine.PostEvent("Dial_PnC_Event", gameObject);
            }
        }
        else
        {
            AkSoundEngine.SetSwitch("Dial_PnC", "T_I", gameObject);
            AkSoundEngine.PostEvent("Dial_PnC_Event", gameObject);
        }
    }

    public void AnalyzeObjectPDial()
    {
        if (objectClicked == "Fleur puante")
        {
            AkSoundEngine.SetSwitch("Dial_PnC", "A_P", gameObject);
            AkSoundEngine.PostEvent("Dial_PnC_Event", gameObject);
        }
        else
        {
            AkSoundEngine.SetSwitch("Dial_PnC", "A_I", gameObject);
            AkSoundEngine.PostEvent("Dial_PnC_Event", gameObject);
        }
    }
}
