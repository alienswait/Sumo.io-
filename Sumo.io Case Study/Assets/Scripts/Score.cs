using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoreText;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(score >= 10)
        {
            YouWin();
        }
    }

    public void YouWin()
    {
        scoreText.text = "You Win!";
        Time.timeScale = 0f;
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        AddScore();
    }
    public void AddScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
