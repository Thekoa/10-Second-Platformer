using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilesMiniGame : MonoBehaviour
{
    public int curButtonOrder;
    public int maxButtonOder=4;
    public bool resetProgress = false;


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
        curButtonOrder = 0;
        resetProgress = true;
    }

}
