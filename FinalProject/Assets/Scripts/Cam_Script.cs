using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam_Script : MonoBehaviour
{
    Transform Camera;
    public Player_Movement playerScript;
    GameObject player;
    Vector3 pos;
    void Start()
    {
        Camera = gameObject.transform;
        pos = new Vector3(0, 0, -10);
        playerScript = player.GetComponent<Player_Movement>();
    }

    void Update()
    {
        Camera.position = pos;
        pos = new Vector3(playerScript.player.position.x, playerScript.player.position.y, -10);
    }
}
