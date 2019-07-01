using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    private float move;
    public bool grounded = false;
    public bool attack = false;
    public float jumpforce = 0f;
    public float speed = 0;
    public int trophy, enemy;

    public bool facingright;
    public GameManager manage;

    public Animator anim;
    Vector3 pos;
    public disable d;
    // private ScoreCaluculator sc;


    void Start()
    {
        // rb = GetComponent<Rigidbody2D> ();
        facingright = true;
        keepPosition();
    }
    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Platform")
        {
            grounded = true;
        }
        else if (col.gameObject.tag == "CalculateScore")
        {
            if (trophy < 5 && enemy <= 8)
            {
                print("You have gone mad behind success");
                SceneManager.LoadScene("Ending2");

            }
            else if (trophy >= 5 && enemy<=4)
            {
                print("Winer ! You have left all problems behind");
                SceneManager.LoadScene("Ending1");
            }
        }
    }
    public void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.tag == "Platform")
        {
            grounded = false;
        }

    }
    private void Handleinput()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            attack = true;
            anim.SetBool("attack", true);
        }

    }
    private void Handleattacks()
    {
        if (attack)
        {
            anim.SetTrigger("attack");
        }

    }
    void Update()
    {
        checkFall();
        Handleinput();
        float move = Input.GetAxis("Horizontal");

        Vector2 movement = new Vector2(move, 0f);

        rb.AddForce(movement * speed);


        // rb.AddForce(new Vector2(move*speed,0),ForceMode2D.Impulse);


        anim.SetFloat("speed", Mathf.Abs(move));

        if (facingright == false && move > 0)
        {
            flip();
        }
        else if (facingright == true && move < 0)
        {
            flip();
        }

        if (Input.GetKey(KeyCode.Space))
        {
            if (grounded)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpforce);
                anim.SetBool("jump", true);
            }
            else
            {
                {
                    anim.SetBool("jump", false);
                }
            }
        }

    }

    void FixedUpdate()
    {

        Handleattacks();
        resetvalues();

    }
    void flip()
    {
        facingright = !facingright;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }

    private void resetvalues()
    {
        attack = false;

    }
    void checkFall()
    {
        if (rb.position.y < -15)
        {
            int scene = SceneManager.GetActiveScene().buildIndex;

            SceneManager.LoadScene(scene);
        }
    }
    void keepPosition()
    {
        pos = transform.position;
    }
    void OnTriggerEnter2D(Collider2D turn)
    {

        if (turn.gameObject.tag == "Next")
        {
            manage.winGame();

        }
        else if (turn.gameObject.tag == "Trophy")
        {
            trophy++;
            Destroy(turn.gameObject);
            d.destroyed=true;
         
            
        }
        else if (turn.gameObject.tag == "Enemy")
        {
            enemy++;
            // anim.SetTrigger ("Shake");
        }
        // else if (turn.gameObject.tag == "Score")
        // {
        //     sc.ClaculateScore();
        // }

    }

}