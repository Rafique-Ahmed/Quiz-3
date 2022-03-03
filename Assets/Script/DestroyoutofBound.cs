using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyoutofBound : MonoBehaviour
{
    private float zRange = 9; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {//Enemies out of bound destroy code
       if(transform.position.z < -zRange){
           Destroy(gameObject);
        }
    }
}
