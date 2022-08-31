using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage = false;
    [SerializeField] float driverDelay = 0.5f; 
    
    

    

    void OnCollisionEnter2D(Collision2D other) {
        //collsion event details
        Debug.Log("Oppsie!");
    }

    // for package pickup 
    //use tags for the package in unity 
    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Package" && !hasPackage){ //pick up the package if driver does not have any 
            Debug.Log("Package Picked up!");
            hasPackage =true ; //change the flag of of having package 
            Destroy(other.gameObject, driverDelay);
           
        }
        if(other.tag =="Customer" && hasPackage){ //only deliver to customer when you have the package 
            Debug.Log("Package Delivered");
            hasPackage =false ; //prevent multiple delivery
        }
    }

    
        
}

