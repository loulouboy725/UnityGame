using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    void Update()
    {
        float dt = Time.deltaTime;
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = new Vector2(transform.position.x + (dt * -5), transform.position.y);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = new Vector2(transform.position.x + (dt * 5), transform.position.y);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + dt * 5);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - dt * 5);
        }
    }
}