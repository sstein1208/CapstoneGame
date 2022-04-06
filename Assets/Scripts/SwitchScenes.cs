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
    public void Tutorial() {  
        // FirstTextCanvas = GameObject.FindWithTag("FirstTextCanvas");
        // FirstTextCanvas.SetActive(true);
        // SecondTextCanvas = GameObject.FindWithTag("SecondTextCanvas");
        // SecondTextCanvas.SetActive(false);
        // WinTextCanvas = GameObject.FindWithTag("WinTextCanvas");
        // WinTextCanvas.SetActive(false); 
        SceneManager.LoadScene("Tutorial"); 
    } 
    public void TestLevel() {  
        SceneManager.LoadScene("TestLevel");  
    }  
    
    public void MainMenu() {  
        SceneManager.LoadScene("MainMenu");  
    } 
    public void OfficeLevel(){
        SceneManager.LoadScene("Office");  
    } 
    public void KitchenLevel(){
        SceneManager.LoadScene("Kitchen");  
    } 

    public void BedroomLevel(){
        SceneManager.LoadScene("Bedroom");  
    } 

    public void CoffeeShopLevel(){
        SceneManager.LoadScene("CoffeeShop");  
    } 
    public void GameRoomLevel(){
        SceneManager.LoadScene("GameRoom");  
    } 
    public void GardenLevel(){
        SceneManager.LoadScene("Garden");  
    } 
    public void LibraryLevel(){
        SceneManager.LoadScene("Library");  
    } 
    public void MorgueLevel(){
        SceneManager.LoadScene("Morgue");  
    } 
    public void SchoolLevel(){
        SceneManager.LoadScene("School");  
    } 
    public void WesternLevel(){
        SceneManager.LoadScene("Western");  
    } 
} 