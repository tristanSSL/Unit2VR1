using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testscript : MonoBehaviour
{
    int health = 5;
    Rigidbody2D player = null;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hp: " + health);
        Debug.Log(player);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
