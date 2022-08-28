using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
   [SerializeField] float turnSpeed = 300;
   [SerializeField] float moveSpeed = 20; 


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {  //delatime will tell us how long exe each frame will take
        float turnAmount = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime; //control with keyboard
        float moveAmount =  Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        



        //object get updated rotation in every signle frame f is for float
        transform.Rotate(0,0,-turnAmount); //use -ve to rotate in correct direction
        transform.Translate(0,moveAmount,0);
        
    }
}
