using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonFuctionMG : MonoBehaviour
{
    public GameObject TilesManager;
    public int buttonNumber;
    int buttonOrder;

    // Start is called before the first frame update
    void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnPress()
    {
        TilesManager.GetComponent<TilesMiniGame>().resetProgress = true;
        buttonOrder = TilesManager.GetComponent<TilesMiniGame>().curButtonOrder;
        //checks if the current number on tiles mini game is equall to this button
        if (buttonNumber == buttonOrder)
        {
            TilesManager.GetComponent<TilesMiniGame>(CorrectButton());
        }
        else 
        {
        }

    }

    void ResetProgress()
    { 
    
    }
}
