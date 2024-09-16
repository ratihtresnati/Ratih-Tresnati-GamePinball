using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreUIController : MonoBehaviour
{
    public TMP_Text scoreText;

    public ScoreManager scoreManager;

    void Update()
    {
        scoreText.text = scoreManager.score.ToString();
    }
}
