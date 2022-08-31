using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
   [SerializeField] float turnSpeed = 300;
   [SerializeField] float moveSpeed = 20; 
    
    [SerializeField] float slowSpeed = 10;
    [SerializeField] float boostSpeed = 27;




    // Update is called once per frame
    void Update()
    {  //delatime will tell us how long exe each frame will take
        float turnAmount = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime; //control with keyboard
        float moveAmount =  Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        



        //object get updated rotation in every signle frame f is for float
        transform.Rotate(0,0,-turnAmount); //use -ve to rotate in correct direction
        transform.Translate(0,moveAmount,0);

      
    }

      void OnTriggerEnter2D(Collider2D other) {
        //collsion event details
        
        if(other.tag == "bumper"){ //tree house rocks are makred as bumper and slow you down
            Debug.Log("Oppsie!");
            moveSpeed = slowSpeed;
        }

        if(other.tag == "booster"){ //yellow cricles that boost you up
            Debug.Log("Gotta speed up!");
            moveSpeed = boostSpeed;
            
        }
    }
}
