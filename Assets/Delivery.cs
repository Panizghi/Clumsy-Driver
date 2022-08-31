using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage = false;
    [SerializeField] float driverDelay = 0.5f; 

    //make sure Alpha is at 255 so the car don't disaapear :)
    [SerializeField] Color32 hasPackColor = new Color32 (54,188,152,255);
    [SerializeField] Color32 noPackColor = new Color32 (227,193,40,255);
    
    SpriteRenderer spriteRenderer;

    void Start(){
        spriteRenderer = GetComponent<SpriteRenderer>(); 
        //use the get the color component later in the code 
    }
    

    

    // for package pickup 
    //use tags for the package in unity 
    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Package" && !hasPackage){ //pick up the package if driver does not have any 
        //package marked with red sqaure sprite with Package tag 
            Debug.Log("Package Picked up!");
            hasPackage =true ; //change the flag of of having package
            spriteRenderer.color = hasPackColor; 
            Destroy(other.gameObject, driverDelay);
           
        }
        if(other.tag =="Customer" && hasPackage){ //only deliver to customer when you have the package 
        //customers marked with white square sprite and Customer tag 
            Debug.Log("Package Delivered");
            hasPackage =false ; //prevent multiple delivery
            spriteRenderer.color = noPackColor;
        }
    }

    
        
}

