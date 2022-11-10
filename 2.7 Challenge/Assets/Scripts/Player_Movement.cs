using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    //defining needed variables
    Vector2 xMove;
    Transform player;
    float xMovement;
    public int xSpeed = 4;
    public Animator animator;
    Rigidbody2D rb;
    public float jumpForce = 300;
    void Start()
    {
        //getting items invariables to use later
        player = gameObject.transform;
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //Checks for if movement key is pressed
        xMovement = Input.GetAxisRaw("Horizontal")*xSpeed;
        //Animations for Movement
        if (xMovement!=0)
        {
            animator.SetBool("Moving", true);
        }
        else
        {
            animator.SetBool("Moving", false);
        }
        //Movement Script for x axis
        xMove = new Vector2(xMovement, 0.0f);
        player.Translate(xMove * Time.deltaTime);
        if (xMovement > 0)
        {
            player.localScale = new Vector3(4.0f, 4.0f, 0.0f);
        }
        if (xMovement < 0)
        {
            player.localScale = new Vector3(-4.0f, 4.0f, 0.0f);
        }
        //Jumping script
        if (rb.velocity.y == 0)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                rb.AddForce(transform.up * jumpForce);
            }
        }
        //Animator for Jumping
        if (rb.velocity.y != 0) 
        {
            animator.SetBool("IsJumping", true);
        }
        else
        {
            animator.SetBool("IsJumping", false);
        }
    }
}
