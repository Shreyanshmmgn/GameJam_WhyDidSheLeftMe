using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    // public GameObject postionToGo, Camera;


    // void OnCollisionEnter2d(Collision2D col)
    // {   print("Inside oncollsion enter -----------");
    //     if (col.collider.tag == "Player")
    //     {   print("Collision detected with player");
    //         Camera.transform.position = postionToGo.transform.position;
    //     }
    // }

    private Transform playerTransform;
    public PlayerMovement pl;
    public float offset;
    public float xInitial;
    public float xFinal;
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void LateUpdate()
    {
        Vector3 temp = transform.position;//store cameras position
        temp.x = Mathf.Clamp(playerTransform.position.x,xInitial,xFinal);//set camera poition x to players postion x
        temp.x += offset;//ading value of offset to temporarory value of camera
        // if (pl.face == true)
        // {
        //     temp.x += offset;//ading value of offset to temporarory value of camera
        // }
        // else
        // {
        //     temp.x += -offset;//ading value of offset to temporarory value of camera
        // }

        transform.position = temp;
    }

}
