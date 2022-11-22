using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    public Player_Movement playerScript;
    public GameObject health;
    private int healthAmount;
    public Text healthText;
    private void Start()
    {
        playerScript = health.GetComponent<Player_Movement>();
    }
    private void Update()
    {
        healthText.text = "Health: " + healthAmount;
        healthAmount = playerScript.healthLeft;
    }
}
