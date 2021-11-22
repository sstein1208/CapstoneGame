using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
using UnityEngine.SceneManagement;  
public class SwitchScenes: MonoBehaviour {  
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

    

} 