using UnityEngine;
using System.Collections;
 
public class PullForce : MonoBehaviour {
 
    [SerializeField]GameObject Sphere;
    [SerializeField]float multiplier;
    Vector3 initPos;
 
    //get the initial positon of the holder before the drag starts
    void OnMouseDown()
    {
        initPos = transform.position;
    }
 
    //move the holder according to the drag
    void OnMouseDrag()
    {
        transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10));
    }
 
    //add force to the disc in the direction of the line between 
    //the current position of the holder and its initial position 
    void OnMouseUp()
    {
        Sphere.GetComponent<Rigidbody>().AddForce((initPos - transform.position) * Vector3.Distance(transform.position, initPos) * multiplier);
    }
}