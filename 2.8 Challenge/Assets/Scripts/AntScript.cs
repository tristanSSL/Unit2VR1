using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntScript : MonoBehaviour
{
    bool walkLeft = true;
    Transform enemy;
    Vector2 move;
    float speed = 2;
    // Start is called before the first frame update
    void Start()
    {
        move = new Vector2(-1,0);
        enemy = gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (enemy.position.x >= -2.69f )
        {
            walkLeft = true;
        }else if (enemy.position.x <= -6)
        {
            walkLeft = false;
        }
        if (walkLeft == true)
        {
            enemy.localScale = new Vector3(3, 3, 0);
            move = new Vector2(-1, 0)*speed;
        }
        else
        {
            enemy.localScale = new Vector3(-3, 3, 0);
            move = new Vector2(1, 0)*speed;
        }
        enemy.Translate(move*Time.deltaTime);
    }
}
