using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveobj : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {// Background moving forward code
          transform.Translate(Vector3.back * Time.deltaTime);
          
    }
    
}
