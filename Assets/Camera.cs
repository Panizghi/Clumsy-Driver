using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    // Start is called before the first frame update
    
        [SerializeField] GameObject objectFollow;

    


    // Update is called once per frame
    void Update()
    {
        transform.position = objectFollow.transform.position + new Vector3(0,0,-30);
    }
}
