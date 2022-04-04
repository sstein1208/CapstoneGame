using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialStart : MonoBehaviour
{
    //public GameObject sphere;
   // public Canvas WTC;
    public Canvas STC;
    public Canvas FTC;
    public GameObject Thrower;
  
    // Start is called before the first frame update
    public void Awake()
    {   
        if(Stats.restartTutorial == true){
            FTC.enabled = false;
            STC.enabled = false;
            Thrower.SetActive(true);
            return;
        }
        //don't activate the spere until popups are closed
        Debug.Log("Inside reset level");
        //set the canvases
        FTC = FTC.GetComponent<Canvas>();
        FTC.enabled = true;
        STC = STC.GetComponent<Canvas>();
        STC.enabled = false;
    
        Thrower.SetActive(false);


    }
    
    public void SecondScreen(){
        //don't activate the spere until popups are closed
        Debug.Log("Inside reset level");

        //set the canvases
        FTC = FTC.GetComponent<Canvas>();
        FTC.enabled = false;
        STC = STC.GetComponent<Canvas>();
        STC.enabled = true;
    
        Thrower.SetActive(false);

    }
    public void DoneSecondScreen(){
        //don't activate the spere until popups are closed
        Debug.Log("Inside reset level");
    
        //set the canvases
        FTC = FTC.GetComponent<Canvas>();
        FTC.enabled = false;
        STC = STC.GetComponent<Canvas>();
        STC.enabled = false;
    

        Thrower.SetActive(true);

    }

   
    

    
}

