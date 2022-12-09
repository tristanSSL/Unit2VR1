using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Script : MonoBehaviour
{
    Transform enemy;
    public Player_Movement playerScript;
    GameObject Player;
    Vector3 pos;
    int posx;
    int posy;
    public Animator anim;
    void Start()
    {
        enemy = gameObject.transform;
        playerScript = Player.GetComponent<Player_Movement>();
        anim = GetComponent<Animator>();
        posx = 0;
        posy = 0;
        anim.SetInteger("Direction", 3);
    }

    void Update()
    {
        if(enemy.position.x < playerScript.player.position.x)
        {
            posx = 2;
            enemy.localScale = new Vector3(3, 3, 0); ;
        }
        else if (enemy.position.x > playerScript.player.position.x)
        {
            posx = -2;
            enemy.localScale = new Vector3(-3, 3, -0);
        }
        if (enemy.position.y < playerScript.player.position.y)
        {
            posy = 2;
            anim.SetInteger("Direction", 1);
        }
        else if (enemy.position.y > playerScript.player.position.y)
        {
            posy = -2;
            anim.SetInteger("Direction", 3);
        } 
        pos = new Vector3(posx, posy, 0);
        enemy.Translate(pos*Time.deltaTime);
    }
}
