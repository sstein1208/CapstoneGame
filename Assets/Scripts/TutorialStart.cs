using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialStart : MonoBehaviour
{
    //public GameObject sphere;
    public Canvas WTC;
    public Canvas STC;
    public Canvas FTC;
  
    // Start is called before the first frame update
    public void Awake()
    {   
        //don't activate the spere until popups are closed
        Debug.Log("Inside reset level");
        //sphere.SetActive(false);
        //set the canvases
        FTC = FTC.GetComponent<Canvas>();
        FTC.enabled = true;
        STC = STC.GetComponent<Canvas>();
        STC.enabled = false;
        WTC = WTC.GetComponent<Canvas>();
        WTC.enabled = false;
        Debug.Log("Deactivate WTC");
    }
    
    public void SecondScreen(){
        //don't activate the spere until popups are closed
        Debug.Log("Inside reset level");
        //sphere.SetActive(false);
        //set the canvases
        FTC = FTC.GetComponent<Canvas>();
        FTC.enabled = false;
        STC = STC.GetComponent<Canvas>();
        STC.enabled = true;
        WTC = WTC.GetComponent<Canvas>();
        WTC.enabled = false;
        Debug.Log("Deactivate WTC");

    }
    public void DoneSecondScreen(){
        //don't activate the spere until popups are closed
        Debug.Log("Inside reset level");
        //sphere.SetActive(true);
        //set the canvases
        FTC = FTC.GetComponent<Canvas>();
        FTC.enabled = false;
        STC = STC.GetComponent<Canvas>();
        STC.enabled = false;
        WTC = WTC.GetComponent<Canvas>();
        WTC.enabled = false;
        Debug.Log("Deactivate WTC");

    }

    

    
}

