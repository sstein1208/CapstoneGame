using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TargetCollision : MonoBehaviour
{
    [SerializeField]
    private Canvas WinText;

    // Start is called before the first frame update
    void Start()
    {
        WinText.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision){
       
        if(collision.gameObject.CompareTag("Target")){
            WinText.enabled = true;
            //collision.gameObject.GetComponent<AudioSource>().Play();
        }
    }
}
