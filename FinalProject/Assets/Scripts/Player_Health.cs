using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Health : MonoBehaviour
{
    public int healthLeft = 3;
    private void Update()
    {
        if(healthLeft == 0)
        {
            SceneManager.LoadScene(3);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy" && healthLeft > 0)
        {
            healthLeft -= 1;
        }
        if(collision.gameObject.tag == "Boss" && healthLeft > 1)
        {
            healthLeft -= 2;
        }else if (collision.gameObject.tag == "Boss" && healthLeft == 1)
        {
            healthLeft = 0;
        }
    }
}
