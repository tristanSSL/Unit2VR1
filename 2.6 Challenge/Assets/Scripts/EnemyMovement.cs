using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    Vector2 xMove;
    Transform Enemy;
    void Start()
    {
        Enemy = gameObject.transform;
    }

    void Update()
    {
        xMove = new Vector2(-2.0f,0.0f);
        Enemy.Translate(xMove*Time.deltaTime);
    }
}
