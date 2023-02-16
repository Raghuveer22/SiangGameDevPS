using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCompleted : MonoBehaviour
{
    [SerializeField] private GameObject GameCompletedSound;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        MenuManager.Instance.OpenMenu("CompleteMenu");
        GameObject Sound = Instantiate(GameCompletedSound, transform.position, transform.rotation);
    }
}
