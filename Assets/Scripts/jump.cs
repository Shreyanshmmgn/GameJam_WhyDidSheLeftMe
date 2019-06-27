using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayerMovement player;
    public float jumpVelocity;
    void Update()
    {
        // if (Input.GetButtonDown("Jump") && player.ground == true)
        // {
        //     GetComponent<Rigidbody2D>().velocity = Vector2.up * jumpVelocity;
        // }
    }
}
