using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emeny: MonoBehaviour
{
  
     public float speed;
    public bool moveright;
      void OnTriggerEnter2D(Collider2D turn)
    {
        if(turn.gameObject.tag == "turn")
        {
            moveright = false;
        }
      
        
        else
        {
            
                moveright = true;

            
        }
    }
   


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(moveright)
        {
            transform.Translate(2*Time.deltaTime*speed,0,0);
            transform.localScale = new Vector2(1.5f,1.5f);
        }
        else
        {
            transform.Translate(-2*Time.deltaTime*speed , 0,0);
            transform.localScale = new Vector2(-1.5f,1.5f);
        }
    }
}
