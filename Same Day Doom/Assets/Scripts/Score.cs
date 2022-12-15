using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    public int score;
    public TextMeshProUGUI scoreText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collision2D other)
    {
        {
        Addscore();
        }
        
    }
    void Addscore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
