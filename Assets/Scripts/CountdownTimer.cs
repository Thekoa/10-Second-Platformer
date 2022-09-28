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
        timeRN -= 1 * Time.deltaTime;
        timerText.text = timeRN.ToString ("0");
        Debug.Log(timeRN);
        
        if (timeRN <= 0)
        {
            timeRN = 0;
        }

    }
}
