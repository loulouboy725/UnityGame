using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public static int playerScore = 0;
    public Text scoreText;

    void Start()
    {
        scoreText = GetComponent<Text>();
    }

    void Update()
    { //Updates the text
        playerScore = Mathf.Clamp(playerScore, 0, 99999999); // Sets range for score
        scoreText.text = (playerScore.ToString());
    }
}
