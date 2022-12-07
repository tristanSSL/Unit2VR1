using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public Transform player;
    Vector3 move;
    public Animator anim;
    Rigidbody2D rb;
    float xMove;
    float yMove;
    public int speed = 4;
    string pressedFirst;
    void Start()
    {
        player = gameObject.transform;
        move = new Vector3(0, 0, 0);
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        pressedFirst = "Void";
    }

    void Update()
    {
        movement();
        pressOrder();
        moveAnimation();
    }
    void movement()
    {
        xMove = Input.GetAxisRaw("Horizontal") * speed;
        yMove = Input.GetAxisRaw("Vertical") * speed;
        move = new Vector3(xMove, yMove, 0);
        player.Translate(move * Time.deltaTime);
        if (xMove < 0)
        {
            player.localScale = new Vector3(-4, 4, 0);
        }
        if (xMove > 0)
        {
            player.localScale = new Vector3(4, 4, 0);
        }
    }

    void pressOrder()
    {
        if(xMove != 0 && yMove == 0)
        {
            pressedFirst = "x";
        }
        if (yMove != 0 && xMove == 0)
        {
            pressedFirst = "y";
        }
        if (xMove == 0 && yMove == 0)
        {
            pressedFirst = "Void";
        }
    }

    void moveAnimation()
    {
        if (xMove != 0 || yMove != 0)
        {
            anim.SetBool("Moving", true);
        } else if (xMove == 0 && yMove == 0)
        {
            anim.SetBool("Moving", false);
        }
        if (yMove < 0 && pressedFirst == "y")
        {
            anim.SetInteger("Direction", 3);
        }
        if (yMove > 0 && pressedFirst == "y")
        {
            anim.SetInteger("Direction", 1);
        }
        if ((xMove < 0 || xMove > 0) && pressedFirst == "x")
        {
            anim.SetInteger("Direction", 2);
        }
    }
}
