using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasketIB : MonoBehaviour
{
    public Text ScoreText;
    public ScoreManager scoreManager;
    // Start is called before the first frame update
    void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (scoreManager.score >= 10)
        {
            YouWin();
        }
    }
    void YouWin()
    {
        ScoreText.text = "You Win!";
        Time.timeScale = 0f;
    }
    private void OnTriggerEnter(Collider other)
    {
        AddScore();
    }

    void AddScore()
    {
        scoreManager.score++;
        ScoreText.text = "Score: " + scoreManager.score.ToString();
    }

}
