using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Increment : MonoBehaviour
{
    [SerializeField] private float lower=1f;
    [SerializeField] private float upper=5f;
    [SerializeField] private float increment=0.05f;
    private bool isIncreasing = false;
    private bool isDecreasing = false;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            isIncreasing = true;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            isDecreasing = true;
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            isIncreasing = false;
        }
        else if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            isDecreasing = false;
        }
        Grow(isIncreasing,isDecreasing);
    }
    void Grow(bool isIncreasing,bool isDecreasing)
    { 
        if (isIncreasing == true && (transform.localScale.x < upper)&& (transform.localScale.y <upper))
        {
            Vector3 localScale = transform.localScale;
            localScale.y += increment;
            localScale.x += increment;
            transform.localScale = localScale; 
        }
        if (isDecreasing == true&& transform.localScale.x > lower && transform.localScale.y >lower)
        {
            Vector3 localScale = transform.localScale;
            localScale.y -= increment;
            localScale.x -= increment;
            transform.localScale = localScale;
        }
    }
}
