using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountdownTimer : MonoBehaviour
{
    private float timeRN = 0f;
    private float startTime = 10f;

    public TMP_Text timerText;

    void Start()
    {
        timeRN = startTime;
    }
    
    void Update()
    {
        //timer counts down by one
        timeRN -= 1 * Time.deltaTime;
        timerText.text = timeRN.ToString ("0");
        
        //timer cache for when it reaches 0
        if (timeRN <= 0)
        {
            timeRN = 0;
        }

    }
}
