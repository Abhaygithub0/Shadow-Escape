using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollector : MonoBehaviour
{
    private TextMeshProUGUI textUGI;

    private void Awake()
    {
        textUGI = GetComponent<TextMeshProUGUI>();
    }
    private void Start()
    {
        updadescorevalue();
    }

    int score = 0;

    public void incrementvalue(int increment)
    {
        score = score + increment;
        updadescorevalue();
       
    }

    private void updadescorevalue()
    {
        textUGI.text = "Coin" + score;
    }
}
