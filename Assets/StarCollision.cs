using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarCollision : MonoBehaviour
{
    public GameObject Star1;
    public GameObject Star2;
    public GameObject Star3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision){
       
        if(collision.gameObject.CompareTag("Star1")){
            //Delete Start 1
            Star1.SetActive(false);
        }
        if(collision.gameObject.CompareTag("Star2")){
            Star2.SetActive(false);

        }
        if(collision.gameObject.CompareTag("Star3")){
            Star3.SetActive(false);
        }
    }
}
