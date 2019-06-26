using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    // Start is called before the first frame update
    // Rigidbody2D rb;
    public PlayerMovement player;
    void OnCollisionEnter2D(Collision2D Cinfo)
    {  
        if (Cinfo.collider.tag == "Platform")
        {
            player.ground = true;
        }
    }
    void OnCollisionExit2D(Collision2D Cinfo)
    {   
        if (Cinfo.collider.tag == "Platform")
        {
            player.ground = false;
        }
    }
}
