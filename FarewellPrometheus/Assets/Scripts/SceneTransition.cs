using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public Animator transition;


    public float transitionTime = 1f;

    public GameObject manager;
    public GameObject currentPanel;
    public GameObject transitionPanel;
    public GameObject nextPanel;
    public GameObject continueButton;

    public int tabNum;
    private Scene currentScene;
    int buildIndex;
    

    public void Start()
    {
        buildIndex = currentScene.buildIndex;
        currentScene = SceneManager.GetActiveScene();

        

        if (buildIndex == 1)
        {
            tabNum = manager.GetComponent<CollisionManager>().tabNum;
        }
    }
    public void LoadNextScene()
    {
       
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
        buildIndex = currentScene.buildIndex;
        if (buildIndex == 1)
        {
            tabNum = manager.GetComponent<CollisionManager>().tabNum;
        }
        AkSoundEngine.SetState("Location", "CL1");
        AkSoundEngine.SetState("Music", "None");
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        // Play Animation
        transition.SetTrigger("Start");
        AkSoundEngine.PostEvent("Woosh_Trans_Event", gameObject);

        // Wait
        yield return new WaitForSeconds(transitionTime);

        // Load scene
        SceneManager.LoadScene(levelIndex);
    }

    public void LoadTransitionPanel()
    {
        StartCoroutine(LoadTransPanel(1f));
    }

    IEnumerator LoadTransPanel(float transTime)
    {
        transition.SetTrigger("Start");

        AkSoundEngine.PostEvent("Woosh_Mus_Event", gameObject);

        yield return new WaitForSeconds(transTime);

        currentPanel = manager.GetComponent<CollisionManager>().tab[tabNum];
        currentPanel.SetActive(false);

        transitionPanel.SetActive(true);

        transition.SetTrigger("End");

        yield return new WaitForSeconds(2f);

        continueButton.SetActive(true);
    }

    public void LoadNextPanel()
    {
        tabNum = manager.GetComponent<CollisionManager>().tabNum;
        StartCoroutine(LoadPanel(1f));
    }

    IEnumerator LoadPanel(float nextTransTime)
    {
        transition.SetTrigger("Start");

        AkSoundEngine.PostEvent("Woosh_Trans_Event", gameObject);

        yield return new WaitForSeconds(nextTransTime);

        

        nextPanel = manager.GetComponent<CollisionManager>().tab[tabNum];
        nextPanel.SetActive(true);

        continueButton.SetActive(false);

        transitionPanel.SetActive(false);

        transition.SetTrigger("End");
    } 
}
