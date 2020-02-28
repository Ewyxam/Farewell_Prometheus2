using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundManager : MonoBehaviour
{
  
    
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
            AkSoundEngine.SetState("Location", "CL1");
            Debug.Log("CL1 AMB");
            AkSoundEngine.SetState("Music", "Exploration");
            AkSoundEngine.PostEvent("Music_Event", gameObject);
        }

        

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

   


}
