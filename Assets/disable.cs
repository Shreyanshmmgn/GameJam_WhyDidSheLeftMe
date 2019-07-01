using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disable : MonoBehaviour
{
    public GameObject platform;
    public bool destroyed;
    void Update()
    {print("false");
        if(destroyed==true)
        {   print("true");
             Destroy(platform);
        }
    }
    // void OnCollisionEnter2D(Collision2D other)
    // {
    //     if (other.gameObject.tag == "Player")
    //     {
           
    //         destroyed = true;
    //         Destroy(trophy);
    //     }
    // }
}
