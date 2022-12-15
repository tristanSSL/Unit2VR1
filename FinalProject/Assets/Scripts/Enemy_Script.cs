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
    bool chase = false;
    public int health= 3;
    void Start()
    {
        enemy = gameObject.transform;
        playerScript = Player.GetComponent<Player_Movement>();
        anim = GetComponent<Animator>();
        posx = 0;
        posy = 0;
        anim.SetInteger("Direction", 3);
        health = 3;
    }

    void Update()
    {
        if (chase == true)
        {
            if (enemy.position.x < playerScript.player.position.x)
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
            enemy.Translate(pos * Time.deltaTime);
        }
        if(health == 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnBecameVisible()
    {
        chase = true;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Arrow" && health > 0)
        {
            health -= 1;
        }
    }
}
