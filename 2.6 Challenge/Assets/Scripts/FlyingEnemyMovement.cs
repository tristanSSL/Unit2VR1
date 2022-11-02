using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingEnemyMovement : MonoBehaviour
{
    Vector2 xMove;
    Transform Enemy;
    void Start()
    {
        Enemy = gameObject.transform;
    }

    void Update()
    {
        xMove = new Vector2(1.5f,-1.0f);
        Enemy.Translate(xMove*Time.deltaTime);
    }
}
