using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    // Start is called before the first frame update
    
        [SerializeField] GameObject objectFollow;

    


    // Update is called once per frame
    void LateUpdate() //using late update due to excution order so camera doesnt move slower than car 
    {
        transform.position = objectFollow.transform.position + new Vector3(0,0,-10);
    }
}
