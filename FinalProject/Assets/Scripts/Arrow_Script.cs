using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow_Script : MonoBehaviour
{
    public Transform arrow;
    public Player_Movement playerScript;
    public GameObject Player;
    public Spawner spawnScript;
    public GameObject spawn;
    Vector3 move;
    void Start()
    {
        arrow = gameObject.transform;
        Player = GameObject.Find("Player");
        playerScript = Player.GetComponent<Player_Movement>();
        spawn = GameObject.Find("Spawner");
        spawnScript = spawn.GetComponent<Spawner>();
    }
    void Update()
    {
        arrow.Translate(spawnScript.move * Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "Boss")
        {
            Destroy(gameObject);
        }
    }
}
