using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ButtonPlatform : MonoBehaviour
{
    [SerializeField] private GameObject[] wayPoints;
    [SerializeField] public int currentWayPointIndex = 0;
    [SerializeField] private float speed = 2f;
    void Update()
    {
       
        transform.position = Vector2.MoveTowards(transform.position, wayPoints[currentWayPointIndex].transform.position, Time.deltaTime * speed);


    }
    public void SetState(int t)
    {
        currentWayPointIndex = t;
    }
}
