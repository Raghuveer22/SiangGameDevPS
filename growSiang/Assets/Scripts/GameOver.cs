using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    [SerializeField]private GameObject GameOverSound;
    [SerializeField] private bool isCollided = false;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(!isCollided)
        {
        MenuManager.Instance.OpenMenu("GameOverMenu");
        GameObject Sound = Instantiate(GameOverSound, transform.position, transform.rotation);
            isCollided = true;
        }
    }
}
