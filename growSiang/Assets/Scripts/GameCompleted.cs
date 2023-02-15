using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCompleted : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        MenuManager.Instance.OpenMenu("CompleteMenu");
        Time.timeScale = 0;
    }
}
