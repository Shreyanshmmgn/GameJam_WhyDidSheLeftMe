using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Destroy : MonoBehaviour
{
    public GameManager manage;
    public bool attack = false;
    void OnCollisionEnter2D(Collision2D Cinfo)
    {
        if (Cinfo.collider.tag == "Player")
        {
            int scene = SceneManager.GetActiveScene().buildIndex;

            SceneManager.LoadScene(scene);
        }
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && attack == false)
        {
            attack = true;
        }
        else if (Input.GetButtonDown("Horizontal") && attack == true)
        {
            attack = false;
        }

    }
    // void LateUpdate()
    // {
    //      if(attack)
    //      {
    //         attack = false;
    //     }
    // }

    public void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "Playerattack")
        {
            {
                if (attack == true)

                    Destroy(gameObject);

            }
        }
    }
}
