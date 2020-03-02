using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Introduction_Animations : MonoBehaviour
{
    public Animator animator;
    public GameObject titleButton;
    public GameObject videoButton;
    public void Title_Animation()
    {
        animator.SetTrigger("title_In");
        GameObject.Find("SoundManager").GetComponent<SoundManager>().MusicStart();
        videoButton.SetActive(false);
        titleButton.SetActive(true);
    }

    public void Title_Out_Animation()
    {
        animator.SetTrigger("title_Out");
        GameObject.Find("SoundManager").GetComponent<SoundManager>().AmbienceStart();
    }

    public void OnFadeComplete()
    {
        GameObject.Find("IntroductionCanvas").SetActive(false);
    }
}
