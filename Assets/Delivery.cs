using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other) {
        //collsion event details
        Debug.Log("Oppsie!");
    }

    // for package pickup 
    //use tags for the package in unity 
    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Package"){
            Debug.Log("Package Picked up!");
        }
    }

    
        
}

