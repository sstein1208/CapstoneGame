using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;  

public class StarCollision : MonoBehaviour
{
    private GameObject WTC;


    public void Start(){
       
        WTC = GameObject.FindGameObjectWithTag("WinTextCanvas");
        if(WTC == null){
            Debug.Log("Scene needs a WTC");
        };

    }
    


    public void OnTriggerEnter(Collider collision){
      Debug.Log("on trigger enter");
        if(collision.gameObject.CompareTag("Star")){
            //Delete Start 1
            collision.gameObject.SetActive(false);
            Stats.num_stars++;
           
        }
        if(collision.gameObject.CompareTag("Target")){
            //Stop the ball when it lands in the trash

            Scene sceneName = SceneManager.GetActiveScene();
            Debug.Log("Scene name" + sceneName.name);
            if(sceneName.name == "Tutorial"){
                Stats.unlocked_levels[1] = true;
                Debug.Log(Stats.unlocked_levels[1]);
            }
            // if(sceneName.name == "KitchenLevel"){
            //     Stats.unlocked_levels[2] = true;
            //     Debug.Log(Stats.unlocked_levels[1]);
            // }

            Debug.Log("Collided with target");
            Rigidbody rb = this.gameObject.GetComponent<Rigidbody>();
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            WTC.transform.GetChild(0).gameObject.SetActive(true);
            TextMeshPro wintext = WTC.transform.GetChild(0).GetChild(0).GetChild(3).GetChild(0).GetComponent<TextMeshPro>();
            GameObject star1 = WTC.transform.GetChild(0).GetChild(0).GetChild(0).gameObject;
            GameObject star2 = WTC.transform.GetChild(0).GetChild(0).GetChild(1).gameObject;
            GameObject star3 = WTC.transform.GetChild(0).GetChild(0).GetChild(2).gameObject;

            //if(Stats.num_stars == 3 || Stats.num_stars == Stats.max_num_stars){
                //display 3 stars
           // wintext.GetComponent<TextMeshPro>().text = "Level Complete!";
                //Stats.totalStarCount += 3;
            Debug.Log("collected 3 stars in tutorial");
            //\\\\\}
            // if(Stats.num_stars == 2){
            //     //display 2 stars
            //     wintext.GetComponent<TextMeshPro>().text = "Level Complete!";
            //     star3.SetActive(false);
            //     Stats.totalStarCount += 2;

            // }
            // if(Stats.num_stars == 1){
            //     //display 1 star
            //     wintext.GetComponent<TextMeshPro>().text = "Level Complete!";
            //     star2.SetActive(false);
            //     star3.SetActive(false);
            //     Stats.totalStarCount += 1;

            //}
            // if(Stats.num_stars == 0){
            //     wintext.GetComponent<TextMeshPro>().text = "Try Again?";
            //     //display no stars
            //     star1.SetActive(false);
            //     star2.SetActive(false);
            //     star3.SetActive(false);

            // }
           


    
        }
        if(collision.gameObject.CompareTag("Miss")){
            //RESET LEVEL if you miss
            Debug.Log("Missed");
            Stats.restartTutorial = true;
            string current_level = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(current_level);
            
        }
       
    }
}
