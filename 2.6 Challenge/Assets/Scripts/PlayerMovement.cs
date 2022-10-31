using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Vector2 xMove;
    Transform player;
    float xMovement;
    float yMovement;
    public int speed = 4;
    void Start()
    {
        player = gameObject.transform;
    }

    void Update()
    {
        xMovement = Input.GetAxis("Horizontal")*speed;
        yMovement = Input.GetAxis("Vertical")*speed;
        xMove = new Vector2(xMovement, yMovement);
        player.Translate(xMove*Time.deltaTime);
    }
}
