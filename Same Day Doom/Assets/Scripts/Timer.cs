using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    float currentTime = 0f;
    float startTime = 200f;
    [SerializeField] TextMeshProUGUI countdownText;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString ("0");

        if (currentTime <= 100)
        {
            countdownText.color = Color.red;
        }

        if (currentTime <= 0)
        {
            currentTime = 0;
        }
    }
}
