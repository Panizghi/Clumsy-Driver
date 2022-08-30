using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage = false;
    [SerializedField] float  destroyPack = 0.5f;
    void OnCollisionEnter2D(Collision2D other) {
        //collsion event details
        Debug.Log("Oppsie!");
    }

    // for package pickup 
    //use tags for the package in unity 
    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Package" && !hasPackage){ //one delivery at a time
            Debug.Log("Package Picked up!");
            hasPackage =true ;
            Destroy(other.GameObject,destroyPack);
        }
        if(other.tag =="Customer" && hasPackage){
            Debug.Log("Package Delivered");
            hasPackage =false ; //prevent multiple delivery
        }
    }

    
        
}

