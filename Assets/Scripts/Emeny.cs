using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emeny : MonoBehaviour
{
    public bool facingPosition;
    public float speed=3f;


    void FixedUpdate()
    {
        if (facingPosition)
        {
            // print("from left to right");
            transform.Translate(2 * Time.deltaTime * speed, 0, 0);
            transform.localScale = new Vector2(1, 1);
        }
        else
        {
            // Debug.Log("From right to left");
            transform.Translate(-2 * Time.deltaTime * speed, 0, 0);
            transform.localScale = new Vector2(-1, 1);
        }
    }
    void OnTriggerEnter2d(Collider2D col)
    {
        Debug.Log("Triggered");
        if (col.gameObject.tag == "turn")
        {
            facingPosition = false;
            print("Inside turn");
        }


        else if (col.gameObject.tag == "turn1")
        {
            facingPosition = true;
            print("Inside turn11111111111111111");
        }
    }
}











// public class Enemyright : MonoBehaviour
// {

//     public float speed;
//     public bool moveright;


//     // Update is called once per frame
//     void FixedUpdate()
//     {
//         if (moveright)
//         {
//             transform.Translate(2 * Time.deltaTime * speed, 0, 0);
//             transform.localScale = new Vector2(1, 1);
//         }
//         else
//         {
//             transform.Translate(-2 * Time.deltaTime * speed, 0, 0);
//             transform.localScale = new Vector2(-1, 1);
//         }
//     }
// }

