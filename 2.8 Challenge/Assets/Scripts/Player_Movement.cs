using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    //needed variables defined
    Vector2 xMove;
    public Transform player;
    float xMovement;
    public int xSpeed = 4;
    public Animator anim;
    Rigidbody2D rb;
    public float jumpForce = 300;
    public float doubleJumpForce = 250;
    int jumpsLeft;
    public int acornNum;
    public int healthLeft;
    void Start()
    {
        //getting components to use later
        player = gameObject.transform;
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        jumpsLeft = 2;
        acornNum = 0;
        healthLeft = 5;
    }

    void Update()
    {
        //determining weather move keys are pressed
        xMovement = Input.GetAxisRaw("Horizontal") * xSpeed;
        //Walking animation
        if (xMovement != 0)
        {
            anim.SetBool("Moving", true);
        }
        else
        {
            anim.SetBool("Moving", false);
        }
        //movement script
        xMove = new Vector2(xMovement, 0);
        player.Translate(xMove * Time.deltaTime);
        if (xMovement > 0)
        {
            player.localScale = new Vector3(4, 4, 0);
        }
        if (xMovement < 0)
        {
            player.localScale = new Vector3(-4, 4, 0);
        }
        //jumping script
        if ((Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.UpArrow)) && jumpsLeft>0)
        {
            if (jumpsLeft == 2)
            {
                rb.AddForce(transform.up * jumpForce);
            }
            if (jumpsLeft == 1)
            {
                rb.AddForce(transform.up * doubleJumpForce);
            }
            anim.SetBool("isJumping", true);
            if (jumpsLeft > 0)
            {
                jumpsLeft -= 1;
            }
        }
        if (healthLeft == 0)
        {
            Destroy(gameObject);
            Debug.Log("Game Over!");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            anim.SetBool("isJumping", false);
            jumpsLeft = 2;
        }
        if (collision.gameObject.tag == "Acorn")
        {
            acornNum += 1;
        }
        if (collision.gameObject.tag == "Enemy" && healthLeft > 0)
        {
            healthLeft -= 1; 
        }
    }

    public void OnBecameInvisible()
    {
        healthLeft = 0;
    }
}