using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health_UI : MonoBehaviour
{
    public Player_Health playerHealth;
    public GameObject health;
    public Animator anim;
    int remainingHealth;
    void Start()
    {
        playerHealth = health.GetComponent<Player_Health>();
    }

    void Update()
    {
        remainingHealth = playerHealth.healthLeft;
        anim.SetInteger("Health", remainingHealth);
    }
}
