using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static Score scoreTxt;
    public Text textBox;
    public int playerScore = 0;

    void Awake()
    {
        scoreTxt = this;
    }

    void Update()
    {
        textBox.text = "Счет: " + playerScore;
    }

    public void AddPlayerPoint()
    {
        playerScore++;
    }
}
