using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    public Transform spawnpoint;
    [SerializeField]
    public GameObject sphere;
    Vector3 originalPos;
    void Start()
    {
        //get the starting location of the ball
        originalPos = new Vector3(spawnpoint.position.x, spawnpoint.position.y, spawnpoint.position.z);
        Debug.Log("Respawn Point: "+ originalPos);
    }

    // Update is called once per frame
   

    public void RespawnBall(){
        //if the ball is launched and does not go in the trashcan, respawn
        sphere.GetComponent<Rigidbody>().isKinematic = false;
        sphere.transform.position = originalPos;
        // sphere.SetActive(true);
        
    }
}
