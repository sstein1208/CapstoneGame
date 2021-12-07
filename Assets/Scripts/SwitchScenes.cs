using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
using UnityEngine.SceneManagement;  
using UnityEngine.UI;
public class SwitchScenes: MonoBehaviour {  
   // public Canvas FirstTextCanvas;
    //public Canvas SecondTextCanvas;
   /// public Canvas WinTextCanvas;
    
    public void Levels() {  
        SceneManager.LoadScene("Levels");  
    }  
    public void Help() {  
        SceneManager.LoadScene("Help");  
    }  
    public void TestLevel() {  
        SceneManager.LoadScene("TestLevel");  
    }  
    public void OfficeLevel(){
        SceneManager.LoadScene("OfficeLevel");  

    } 
    public void MainMenu() {  
        SceneManager.LoadScene("MainMenu");  
    } 
    public void Tutorial() {  
        // FirstTextCanvas = GameObject.FindWithTag("FirstTextCanvas");
        // FirstTextCanvas.SetActive(true);
        // SecondTextCanvas = GameObject.FindWithTag("SecondTextCanvas");
        // SecondTextCanvas.SetActive(false);
        // WinTextCanvas = GameObject.FindWithTag("WinTextCanvas");
        // WinTextCanvas.SetActive(false); 
        SceneManager.LoadScene("Tutorial"); 
    } 

    

} 