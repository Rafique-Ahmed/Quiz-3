using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DectectCollision : MonoBehaviour
{
    // public GameObject[] Horse;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision){
        //isOnGround = true;
//Collision with different objects
        if(collision.gameObject.CompareTag("EnemyR")){
            Destroy(gameObject);
            Destroy(collision.gameObject);
        //    Horse[0].SetActive(true);
        //    Horse[1].SetActive(false);
         //   Horse[2].SetActive(false);
        
        }
        else if(collision.gameObject.CompareTag("EnemyG")){
            Destroy(gameObject);
            Destroy(collision.gameObject);
        //    Horse[0].SetActive(false);
        //    Horse[1].SetActive(true);
         //   Horse[2].SetActive(false);
        }
        else if(collision.gameObject.CompareTag("EnemyY")){
            Destroy(gameObject);
            Destroy(collision.gameObject);
         //   Horse[0].SetActive(false);
        //    Horse[1].SetActive(false);
         //   Horse[2].SetActive(true);
        }
    }
}
