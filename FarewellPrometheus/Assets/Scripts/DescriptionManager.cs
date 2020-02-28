﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DescriptionManager : MonoBehaviour
{
    public Text descriptionText;
    private Queue<string> descriptions;
    public DescriptionTrigger destrig;
    public ScanTrigger scantrig;
    public GameObject dialman, loginrobot, clairiere, jungle, riviere,camp,goout,loading;
    public InputField orderfield;
    private string[] orders = new string[] {"nord","sud","est","ouest","scan" };
   // private string[] zoneName = new string[] { "clairiere", "jungle", "riviere", "camp" };
    private string getorder;
    public string descName;
    private int i = 0;
    public GameObject[] scan;
    public Animator cam;


   
    void Start()
    {
        descriptions = new Queue<string>(); 

    }

    public void StartDescription(Description description)
    {
        descName = description.name;

        descriptions.Clear();

        foreach (string descline in description.descriptions)
        {
            descriptions.Enqueue(descline);
        }

        DisplayNextDescline();

    }

    public void DisplayNextDescline()
    {
        if (descriptions.Count == 0)
        {
            EndDescription();
            
            return;
        
        }

        string descline = descriptions.Dequeue();

        StopAllCoroutines();
        StartCoroutine(TypeSentence(descline));
        
    }

    IEnumerator TypeSentence(string descline)
    {
        descriptionText.text = " ";

        foreach (char letter in descline) //isoler les lettres pour les mettre une a une pour apparaitre petit à petit avec un delai
        {
            descriptionText.text += letter;
            yield return new WaitForSeconds(.01f);

        }
        CleanSelectInput();

    }

    public void EndDescription()
    {
        Debug.Log("End of description");
    }


    //order 0 nord   1 sud    2 est   3 ouest   4 scan
    public void CheckOrder()
    {
        getorder = orderfield.GetComponent<InputField>().text.ToLower();
        if (getorder == "exit" && i !=3)
        {
            ExitScan();

        }else if (getorder == "logout" && i ==3)
        {
            CleanSelectInput();
            orderfield.DeactivateInputField();
            descriptionText.text = "";
            cam.SetBool("pan", false);
            goout.SetActive(true);
            dialman.GetComponent<DialogueManager>().StartDialogue(goout.GetComponent<DialogueTrigger>().dialogue);

            
        }
        else if (descName == "loginrobot")//ecran tuto commande robot
        {

            if (getorder == orders[4])//order 4 c'est scan
            {
                clairiere.GetComponent<Animator>().SetBool("CL", true);
                //destrig = clairiere.GetComponent<DescriptionTrigger>();
                //StartDescription(destrig.description);
                //CleanSelectInput();
                AkSoundEngine.PostEvent("Robot_Operational", gameObject);

            }
            else DisplayErrorOrder();


        }
        else if (descName == "cl") //ecran clairiere
        {
            
            i = 0;
            if (getorder == orders[0])
            {
                //clairiere.GetComponent<Animator>().SetBool("CL", false);
                clairiere.GetComponent<Animator>().SetBool("CL", false);
                jungle.GetComponent<Animator>().SetBool("JG", true);
                //destrig = jungle.GetComponent<DescriptionTrigger>();
                //StartDescription(destrig.description);
                // CleanSelectInput();
                
            }
            else if (getorder == orders[4]) // scan
            {

                LaunchScan();
               // CleanSelectInput();

            }
            else DisplayErrorOrder();



        }
        else if (descName == "jg")//ecran jungle
        {
            

            i = 1;
            if (getorder == orders[3])//ouest
            {
                jungle.GetComponent<Animator>().SetBool("JG", false);
                riviere.GetComponent<Animator>().SetBool("RV", true);
                // destrig = riviere.GetComponent<DescriptionTrigger>();
                // StartDescription(destrig.description);
                // CleanSelectInput();

            }
            else if (getorder == orders[1]) //sud
            {
                jungle.GetComponent<Animator>().SetBool("JG", false);
                clairiere.GetComponent<Animator>().SetBool("CL", true);
                //destrig = clairiere.GetComponent<DescriptionTrigger>();
                //StartDescription(destrig.description);
                // CleanSelectInput();

            }
            else if (getorder == orders[4]) // scan
            {

                LaunchScan();
               // CleanSelectInput();

            }
            else DisplayErrorOrder();


        }
        else if (descName == "rv")//ecran riviere
        {
            i = 2;
            if (getorder == orders[0])//nord
            {
                riviere.GetComponent<Animator>().SetBool("RV", false);
                camp.GetComponent<Animator>().SetBool("CP", true);
                /*destrig = camp.GetComponent<DescriptionTrigger>();
                StartDescription(destrig.description);
                CleanSelectInput();*/

            }
            else if (getorder == orders[2]) //est
            {
                riviere.GetComponent<Animator>().SetBool("RV", false);
                jungle.GetComponent<Animator>().SetBool("JG", true);
                /* destrig = jungle.GetComponent<DescriptionTrigger>();
                 StartDescription(destrig.description);
                // CleanSelectInput();*/

            }
            else if (getorder == orders[4]) // scan
            {

                LaunchScan();
               // CleanSelectInput();

            }
            else DisplayErrorOrder();


        }
        else if (descName == "cp")//ecran camp
        {
            i = 3;
            if (getorder == orders[1])//sud
            {
                camp.GetComponent<Animator>().SetBool("CP", false);
                riviere.GetComponent<Animator>().SetBool("RV", true);
               /* destrig = riviere.GetComponent<DescriptionTrigger>();
                StartDescription(destrig.description);
               // CleanSelectInput();*/

            }
            else if (getorder == orders[4])
            {
                
               
                //insérer image mort robot

                loading.SetActive(true);
                camp.GetComponent<Animator>().SetBool("CP", false);
                scan[i].GetComponent<Animator>().SetBool("RB", true);
                loading.GetComponent<Animator>().SetBool("load",true);
                AkSoundEngine.PostEvent("Robot_Shutdown", gameObject);
 
                
                   /* loading.SetActive(false);
                    LaunchScan();
                    CleanSelectInput();*/

            }
            else DisplayErrorOrder();
        }
        else DisplayErrorOrder();
    }



    public void CleanSelectInput()
    {

        orderfield.Select();
        orderfield.text = "";
        getorder = "";
        orderfield.ActivateInputField();
    }

    public void LaunchScan()
    {
        scantrig = scan[i].GetComponent<ScanTrigger>();
        StartDescription(scantrig.scan);
        if (i == 3)
        {
            loading.SetActive(false);
            //CleanSelectInput();

            //AkSoundEngine.PostEvent("Robot_Shutdown", gameObject);
        }
        else
        {
            AkSoundEngine.PostEvent("Robot_Scanning", gameObject);
        }
        
    }

    public void ExitScan()
    {


        destrig = scan[i].GetComponentInParent<DescriptionTrigger>();
        StartDescription(destrig.description);
       // CleanSelectInput();

    }

    public void DisplayErrorOrder()
    {
        CleanSelectInput();
        descriptionText.text = descriptionText.text + "\n commande invalide";
        AkSoundEngine.PostEvent("Robot_Invalid_Command", gameObject);
    }

}
