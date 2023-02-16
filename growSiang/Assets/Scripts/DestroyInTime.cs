using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyInTime : MonoBehaviour
{
    [SerializeField] private float timer=0;
    [SerializeField] private float intervalTime;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0f;

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer>intervalTime)
        {
            Destroy(gameObject);
            Time.timeScale = 0;
        }

    }
}
