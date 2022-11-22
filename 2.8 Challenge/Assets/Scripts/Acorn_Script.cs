using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acorn_Script : MonoBehaviour
{
    Transform Acorn;
    Vector2 vanish;
    // Start is called before the first frame update
    void Start()
    {
        Acorn = gameObject.transform;
        vanish = new Vector2(-1000, -1000);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
