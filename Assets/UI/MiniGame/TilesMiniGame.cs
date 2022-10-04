using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilesMiniGame : MonoBehaviour
{
    public GameObject miniGamePanel;
    public int curButtonOrder = 1;
    int maxButtonOder = 4;
    public bool resetProgress = false;
    public GameObject Timer;
    
    void Awake() 
    {
        Cursor.visible = true;
        curButtonOrder = 1;
    }

    void Update() 
    {
        if (maxButtonOder == (curButtonOrder - 1))
        {
            DifficultyIncrease();
            miniGamePanel.SetActive(false);
            Timer.GetComponent<CountdownTimer>().ResetTimer();
        }
    }

    public void DifficultyIncrease()
    {
        maxButtonOder++;
        IncorrectButton();
    }

    public void CorrectButton() 
    {
        curButtonOrder++;
    }

    public void IncorrectButton()
    {
        curButtonOrder = 1;
        resetProgress = true;
    }

}
