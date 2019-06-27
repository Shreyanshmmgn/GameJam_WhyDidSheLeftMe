using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameManager manage;
    void OnCollisionEnter2D(Collision2D Cinfo)
    {
        if (Cinfo.collider.tag == "Player")
        {
            manage.EndGame();
        }
    }
}