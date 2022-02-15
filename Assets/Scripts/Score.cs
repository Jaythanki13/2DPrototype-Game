using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public static int ballCount;
    public TMP_Text scoreText;

    void Start()
    {
        ballCount = 0;
        scoreText = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = ballCount.ToString();
    }
}