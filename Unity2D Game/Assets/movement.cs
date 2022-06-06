using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    private Rigidbody2D body;
    bool grounded;

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        body.velocity = new Vector2(Input.GetAxis("Horizontal") * 10, body.velocity.y);
        if (Input.GetKey(KeyCode.Space) && grounded == true)
        {
           jump();
        }
    }
    void jump()
    {
        body.velocity = new Vector2(body.velocity.x, 10);
        grounded = false;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            grounded = true;
        }
    }
}