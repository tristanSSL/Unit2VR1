using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    public void RetryGame()
    {
        SceneManager.LoadScene("Level 1");
    }
    public void exitGame()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
