using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    public float speed = 0.05f;
    Vector3 pointA; 
    Vector3 pointB; 

    void Start()
    {
        pointA = new Vector3(-2.13f, 3f, -4f);
        pointB = new Vector3(1.89f, 3f, -4f);
    }

    void Update()
    {
        //PingPong between 0 and 1
        float time = Mathf.PingPong(Time.time * speed, 1);
        transform.position = Vector3.Lerp(pointA, pointB, time);
    }
}


