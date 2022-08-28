using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
   [SerializeField] float turnSpeed = 0.001f;
   [SerializeField] float moveSpeed = 0.001f; 


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   float turnAmount = Input.GetAxis("Horizontal") * turnSpeed; //control with keyboard
        float moveAmount =  Input.GetAxis("Vertical") * moveSpeed;
        //object get updated rotation in every signle frame f is for float
        transform.Rotate(0,0,-turnAmount); //use -ve to rotate in correct direction
        transform.Translate(0,moveSpeed,0);
        
    }
}
