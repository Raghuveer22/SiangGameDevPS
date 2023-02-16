using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyBullet : MonoBehaviour
{
    private Rigidbody2D rb;
    public float force;
    private float timer;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Vector3 direction =  transform.position;
        rb.velocity = new Vector2(0, -direction.y).normalized * force;
        float rot=Mathf.Atan2(direction.y,direction.x)*Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rot+90);


    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer>4f)
        {
            Destroy(gameObject);
        }
    }
  
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("BackGround"))
        {
            Destroy(gameObject);

        }
        if(collision.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0;
            MenuManager.Instance.OpenMenu("GameOverMenu");
        }
    }
}
