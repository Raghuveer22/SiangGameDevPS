using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]private float horizontal;
    [SerializeField]private float speed=1f;
    [SerializeField] private Rigidbody2D rb;
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
    }
    void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }
   

}
