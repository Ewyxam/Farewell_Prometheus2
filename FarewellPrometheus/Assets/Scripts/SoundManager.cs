using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundManager : MonoBehaviour
{
   // private GameObject collisionManager;
    public int location; 
    void Start()
    {
        // Create a temporary reference to the current scene.
        Scene currentScene = SceneManager.GetActiveScene();

        // Retrieve the index of the scene in the project's build settings.
        int buildIndex = currentScene.buildIndex;

        if (buildIndex == 0)
        {
            AkSoundEngine.SetState("Location", "None");
            AkSoundEngine.SetState("Music", "Title");
        }
        else if (buildIndex == 1)
        {
           // collisionManager = GameObject.Find("CollisionManager");
            AkSoundEngine.SetState("Location", "CL1");
            Debug.Log("CL1 AMB");
        }

        /*location = collisionManager.GetComponent<CollisionManager>().tabNum;
        AkSoundEngine.SetState("Music", "Title");
        if(location == 0)
        {
            AkSoundEngine.SetState("Location", "CL1");
            Debug.Log("CL1 AMB");
        }
        else
        {
            AkSoundEngine.SetState("Location", "None");
        }*/

        AkSoundEngine.PostEvent("Ambience_Event", gameObject);
    }

    public void MusicStart()
    {
        AkSoundEngine.PostEvent("Music_Event", gameObject);
    }

    public void AmbienceStart()
    {
        AkSoundEngine.SetState("Location", "VS1");
        AkSoundEngine.SetState("Music", "Stasis");
    }

    public void StartButtonSound()
    {
        AkSoundEngine.SetState("Music", "Awake");
        AkSoundEngine.PostEvent("Computer_Start", gameObject);
    }

    public void PostitHandle()
    {
        AkSoundEngine.PostEvent("Post_it_Handle", gameObject);
    }

    public void SetAmbienceVS1()
    {
        AkSoundEngine.SetState("Location", "VS1");
    }

    /*public void SetAmbience()
    {
        if(location == 0)
        {
            AkSoundEngine.SetState("Location", "CL1");
        }

        if (location == 1)
        {
            AkSoundEngine.SetState("Location", "JG1");
        }

        if (location == 2)
        {
            AkSoundEngine.SetState("Location", "RV1");
        }
    }*/


}
