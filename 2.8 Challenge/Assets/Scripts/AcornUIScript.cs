using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AcornUIScript : MonoBehaviour
{
    public Player_Movement playerScript;
    public GameObject acorn;
    private int acorns;
    public Text acornText;
    private void Start()
    {
        playerScript = acorn.GetComponent<Player_Movement>();
    }
    private void Update()
    {
        acornText.text = "Acorns: " + acorns;
        acorns = playerScript.acornNum;
    }
}
