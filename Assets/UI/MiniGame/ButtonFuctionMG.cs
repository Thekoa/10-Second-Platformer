using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonFuctionMG : MonoBehaviour
{
    public GameObject TilesManager;
    public int buttonNumber;
    int buttonOrder;


    // Start is called before the first frame update
    void Awake()
    {
        buttonOrder = TilesManager.GetComponent<TilesMiniGame>().curButtonOrder;
    }

    // Update is called once per frame
    void Update()
    {
        buttonOrder = TilesManager.GetComponent<TilesMiniGame>().curButtonOrder;
        if (TilesManager.GetComponent<TilesMiniGame>().resetProgress == true)
        {
            ResetProgress();
            GetComponent<Button>().interactable = true;

        }
    }

    public void ButtonFunction()
    {
        print("button clicked");
        TilesManager.GetComponent<TilesMiniGame>().resetProgress = false;
        print(buttonOrder);
        //checks if the current number on tiles mini game is equall to this button
        if (buttonNumber == buttonOrder)
        {
            TilesManager.GetComponent<TilesMiniGame>().CorrectButton();
            print("Correct");
            GetComponent<Button>().interactable = false;
        }
        else 
        {
            TilesManager.GetComponent<TilesMiniGame>().IncorrectButton();
            print("Wrong");
        }
    }

    void ResetProgress()
    {
        print("Reseting");
    }
}
