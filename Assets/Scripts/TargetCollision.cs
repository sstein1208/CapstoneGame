using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;



public class TargetCollision : MonoBehaviour
{
    [SerializeField]
    //private Canvas WinText;
    //public float timeToWait = 5f;
    //public float done = 0.0f;
    public Rigidbody sphereRB;
    public Canvas WTC;
    public Canvas STC;
    public Canvas FTC;
    public int num_stars = 0;
    public TMP_Text wintext;
    public GameObject star1;
    public GameObject star2;
    public GameObject star3;

    

     

    // Start is called before the first frame update
    void Start()
    {
        //sphereRB = GetComponent<Rigidbody>();
        //WinText.enabled = false;
    }

    // Update is called once per frame

    void OnTriggerEnter(Collider collision){
       
        if(collision.gameObject.CompareTag("Star")){

            num_stars++;



            //stop the ball's velocity
            //sphereRB.velocity = Vector3.zero;
            //sphereRB.angularVelocity = Vector3.zero;
            Scene current_scene = SceneManager.GetActiveScene(); //get current level name
            if(current_scene.name == "Tutorial"){
                //automatically give 3 stars
                num_stars = 3;
            }
            else{
                //displauy correct number of stars
                num_stars = 0;
            }
            //Debug.Log("Trying to stop ball's velocity");
            //StartCoroutine(Text());
            //WinText.enabled = true;
            //collision.gameObject.GetComponent<AudioSource>().Play();
        }
    }

    IEnumerator Text(){
        Debug.Log("waiting 2 seconds");
        yield return new WaitForSeconds(2);
        WTC.enabled = true;
        if(num_stars == 3){
            //display 3 stars
            wintext.GetComponent<TextMeshPro>().text = "Level Complete!";
        }
        if(num_stars == 2){
            //display 2 stars
            wintext.GetComponent<TextMeshPro>().text = "Level Complete!";
            star3.SetActive(false);
        }
        if(num_stars == 1){
            //display 1 star
            wintext.GetComponent<TextMeshPro>().text = "Level Complete!";
            star2.SetActive(false);
            star3.SetActive(false);
        }
        if(num_stars == 0){
            wintext.GetComponent<TextMeshPro>().text = "Try Again?";
            //display no stars
            star1.SetActive(false);
            star2.SetActive(false);
            star3.SetActive(false);

        }
        WTC.enabled = true;
    }
    
    
}
