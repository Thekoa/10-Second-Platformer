using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountdownTimer : MonoBehaviour
{
    private float timeRN = 0f;
    private float startTime = 10f;
    public GameObject miniGame;
    bool miniGameTimer = false;
    public TMP_Text timerText;
    public GameObject gameOverMenu;

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
        if (timeRN <= 0 &&( miniGameTimer == false))
        {
            miniGame.SetActive(true);
            timeRN = 10;
        }
        else if (timeRN <= 0 && (miniGameTimer == true)) 
        {
            timeRN = 0;
            miniGame.SetActive(false);
            gameOverMenu.SetActive(true);
        }
    }

    public void ResetTimer()
    {
        timeRN = 10;
    }
}
