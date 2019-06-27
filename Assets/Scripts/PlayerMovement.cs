using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float move, jump = 5f;
    public bool ground = false;

    public bool face;

    public Animator anim;
    void Start()
    {
        face = true;
    }

    void FixedUpdate()
    {
        move = Input.GetAxisRaw("Horizontal");

        movement(move);
        flip(move);
        attack();
    }

    public void movement(float move)
    {
        rb.AddForce(new Vector2(move, 0), ForceMode2D.Impulse);
        Jump();

    }
    public void Jump()
    {print("Jump");
        if (Input.GetButtonDown("Jump") && ground == true)
        {
            rb.AddForce(new Vector2(0, jump), ForceMode2D.Impulse);
        }
    }

    void attack()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            anim.SetTrigger("Gun");
        }

    }

    public void flip(float horizontal)
    {
        if(horizontal>0 && !face || horizontal<0 && face )
        {
            face = !face;
            Vector3 theScale =transform.localScale;
            theScale.x*= -1;
            transform.localScale =theScale;
        }
    }

}
