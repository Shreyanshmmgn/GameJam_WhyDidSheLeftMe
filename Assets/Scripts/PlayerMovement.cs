using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float move, jump = 5f;
    public bool ground = false;

    void FixedUpdate()
    {
        move = Input.GetAxisRaw("Horizontal");

        movement(move);
    }

    public void movement(float move)
    {
        rb.AddForce(new Vector2(move, 0), ForceMode2D.Impulse);
        Jump();

    }
    public void Jump()
    {   
        if (Input.GetButtonDown("Jump")&& ground==true)
         { 
             rb.AddForce(new Vector2(0,jump),ForceMode2D.Impulse);
          }
    }

}
