using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject PauseMenuUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        AkSoundEngine.SetState("Pause", "Not_Paused");
        GameIsPaused = false;
        GameObject.Find("SceneTransition").GetComponent<SceneTransition>().transActive = 0;
    }

    void Pause()
    {
        PauseMenuUI.SetActive(true);
        AkSoundEngine.SetState("Pause", "Paused");
        GameIsPaused = true;
        GameObject.Find("SceneTransition").GetComponent<SceneTransition>().transActive = 1;
    }

    public void LoadOptions()
    {
        Debug.Log("Loading Options");
    }

    public void QuitGame()
    {
        Debug.Log("QUIT !");
        Application.Quit();
    }
}
