using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject arrow;
    public Transform arrowPos;
    public Player_Movement playerScript;
    GameObject Player;
    public bool justSpawned;
    public Vector3 move;
    int posx;
    int posy;
    void Start()
    {
        arrowPos = gameObject.transform;
        playerScript = Player.GetComponent<Player_Movement>();
        justSpawned = false;
    }

    void Update()
    {
        justSpawned = false;
        if (Input.GetKeyDown(KeyCode.Z))
        {
            arrowPos.rotation = new Quaternion(0, 0, 0, 0);
            arrowPos.position = new Vector3(playerScript.player.position.x, playerScript.player.position.y, 0);
            if (playerScript.facingDirection == "North")
            {
                transform.rotation = Quaternion.Euler(Vector3.forward * 0);
                posx = 0;
                posy = 5;
            } else if (playerScript.facingDirection == "East")
            {
                transform.rotation = Quaternion.Euler(Vector3.forward * 270);
                posx = 5;
                posy = 0;
            } else if (playerScript.facingDirection == "South")
            {
                transform.rotation = Quaternion.Euler(Vector3.forward * 180);
                posx = 0;
                posy = -5;
            } else if (playerScript.facingDirection == "West"){
                transform.rotation = Quaternion.Euler(Vector3.forward * 90);
                posx = -5;
                posy = 0;
            }
            move = new Vector3( posx, posy, 0);
            justSpawned = true;
            Instantiate(arrow, arrowPos.position, arrowPos.rotation);            
        }
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
