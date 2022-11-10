using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    //needed variables defined
    Vector2 xMove;
    Transform player;
    float xMovement;
    public int xSpeed = 4;
    public Animator anim;
    Rigidbody2D rb;
    public float jumpForce = 350;
    int jumpsLeft;
    void Start()
    {
        //getting components to use later
        player = gameObject.transform;
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //determining weather move keys are pressed
        xMovement = Input.GetAxisRaw("Horizontal")*xSpeed;
        //Walking animation
        if (xMovement !=0)
        {
            anim.SetBool("Moving", true);
        }
        else
        {
            anim.SetBool("Moving", false);
        }
        //movement script
        xMove = new Vector2(xMovement,0);
        player.Translate(xMove*Time.deltaTime);
        if (xMovement > 0)
        {
            player.localScale = new Vector3(4,4,0);
        }
        if (xMovement< 0)
        {
            player.localScale = new Vector3(-4,4,0);
        }
        //jumping script
        if (rb.velocity.y == 0)
        { 
            if (Input.GetKeyDown(KeyCode.Z)||Input.GetKeyDown(KeyCode.UpArrow))
            {
                rb.AddForce(transform.up*jumpForce);
            }
        }
        //Jumping animation
        if (rb.velocity.y != 0)
        {
            anim.SetBool("isJumping", true);
        }
        else
        {
            anim.SetBool("isJumping", false);
        }
    }
}
