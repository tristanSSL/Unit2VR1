using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Vector2 xMove;
    Transform player;
    float xMovement;
    float yMovement;
    public int xSpeed = 4;
    public int ySpeed = 6;
    void Start()
    {
        player = gameObject.transform;
    }

    void Update()
    {
        xMovement = Input.GetAxisRaw("Horizontal")*xSpeed;
        yMovement = Input.GetAxisRaw("Vertical")*ySpeed;
        xMove = new Vector2(xMovement, yMovement);
        player.Translate(xMove*Time.deltaTime);
        if (xMovement > 0)
        {
            player.localScale = new Vector3(7.0f, 7.0f, 0.0f);
        }
        if (xMovement < 0)
        {
            player.localScale = new Vector3(-7.0f, 7.0f, 0.0f);
        }
    }
}
