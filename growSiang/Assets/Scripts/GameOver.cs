using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        MenuManager.Instance.OpenMenu("GameOverMenu");
        Time.timeScale = 0;
    }
}
