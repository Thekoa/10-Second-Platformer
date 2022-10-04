using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilesMiniGame : MonoBehaviour
{
    public int curButtonOrder = 1;
    int maxButtonOder = 4;
    public bool resetProgress = false;

    void Awake() 
    {
        curButtonOrder = 1;
    }

    void Update() 
    {
    
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
