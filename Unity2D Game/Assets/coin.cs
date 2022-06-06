using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.gameObject.tag == "Character")
        {
            score.playerScore += 100;
            Destroy(gameObject);
        }
    }
}
