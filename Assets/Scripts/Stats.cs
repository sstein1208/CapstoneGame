using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Stats : MonoBehaviour
{
    public static int num_stars = 0;
    public static int max_num_stars = 3;
    public static bool restartTutorial = false;

    public static int totalStarCount = 0;
    //public GameObject StarDisplay;
    
    public static bool[] unlocked_levels =  new bool[11];
    public static bool[] completed_levels = new bool[11];
    // Start is called before the first frame update
    void Start()
    {
        //StarDisplay = GameObject.FindGameObjectWithTag("StarDisplay");
        //TextMeshPro starCount = StarDisplay.transform.GetChild(0).GetComponent<TextMeshPro>();
        //starCount.text = totalStarCount.ToString();

        GameObject[] stars = GameObject.FindGameObjectsWithTag("Star");
        if(stars != null){
            max_num_stars = stars.Length;
        }
        else {
            Debug.Log("Scene needs stars!");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
