using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelsController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject LevelsCanvas;
    public static bool[] unlocked_levels;
    public static bool[] completed_levels;

    public static int totalStarCount;
    async void Start()
    {
        // //Display the number of total stars
        // totalStarCount = Stats.totalStarCount;
        // Debug.Log("Total star count: "+ totalStarCount);
        // GameObject starCountObject = GameObject.FindGameObjectWithTag("LevelsCanvas").transform.GetChild(0).GetChild(0).GetChild(0).gameObject;
        // TextMeshPro starCountText = starCountObject.GetComponent<TextMeshPro>();
        // starCountText.text = totalStarCount.ToString();

        
        //Get the info from stats on what levels are unlocked
        unlocked_levels = Stats.unlocked_levels;
        completed_levels = Stats.completed_levels;
        for(int i = 1; i < unlocked_levels.Length; i++){
            if(unlocked_levels[i] == true){
                //then deactivate the lock
                Debug.Log("level 1 should be unlocked");
                GameObject lock1 = GameObject.FindGameObjectWithTag("LevelsCanvas").transform.GetChild(3).GetChild(1).gameObject;
                lock1.SetActive(false);
                
            }
            // if(completed_levels[i] == true){
            //     //display stars
            //     GameObject stars = GameObject.FindGameObjectWithTag("Level1Button").transform.GetChild(2).gameObject;
            //     stars.SetActive(true);
            // }
        }

       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
