using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Vector2 xMove;
    Transform player;
    void Start()
    {
        xMove = new Vector2(1f,0f);
        player = gameObject.transform;
    }

    void Update()
    {
        player.Translate(xMove*Time.deltaTime);
    }
}
