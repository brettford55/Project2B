using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Apple : MonoBehaviour
{


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bounds")
        {
            FindObjectOfType<GameStatus>().TakeALife();
            Destroy(this.gameObject);
           
        }
    }

}  
        
        
      





