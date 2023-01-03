using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    public int score;
    public TextMeshProUGUI scoreText;
    public Rigidbody2D _boxRB;
    public Collision2D _player;
    void Start()
    {
        _boxRB = GetComponent<Rigidbody2D>();
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
