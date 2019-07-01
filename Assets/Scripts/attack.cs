using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D Cinfo)
    {
        Debug.Log("Attacked by gun");
        if (Cinfo.collider.tag == "Enemy")
        {
            Destroy(Cinfo.gameObject);
        }
        // if (rb.velocity.y < 0)
        // {
        //     rb.velocity += Vector2.up * Physics2D.gravity.y * (fall - 1) * Time.deltaTime;
        // }
        // else if (rb.velocity.y > 0 && !Input.GetButton("Jump"))
        // {
        //     rb.velocity += Vector2.up * Physics2D.gravity.y * (lowJump - 1) * Time.deltaTime;
        // }
    }
}
