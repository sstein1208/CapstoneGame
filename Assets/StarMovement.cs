using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarMovement : MonoBehaviour
{
     public float speed = 0.05f;
    Vector3 pointA; 
    Vector3 pointB; 

    void Start()
    {
       pointA = new Vector3(-2.13f, 4.17f, -4.64f);
        pointB = new Vector3(1.89f, 4.17f, -4.64f);
    }

    void Update()
    {
        //PingPong between 0 and 1
        float time = Mathf.PingPong(Time.time * speed, 1);
        transform.position = Vector3.Lerp(pointA, pointB, time);
    }
}
