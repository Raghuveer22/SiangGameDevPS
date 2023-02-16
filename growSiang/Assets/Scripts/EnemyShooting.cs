using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletPos;
    private float timer=0f;
    [SerializeField] private float nearDistance;
    private GameObject player;
   [SerializeField] private float intervalTime = 4f;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        float distance = Vector2.Distance(transform.position, player.transform.position);
        if(distance < nearDistance)
        {
            timer += Time.deltaTime;
            if(timer>intervalTime)
            {
                timer= 0f;
                shoot();
            }
        }
    }
    void shoot()
    {
        Instantiate(bullet, bulletPos.position, Quaternion.identity);
    }
}
