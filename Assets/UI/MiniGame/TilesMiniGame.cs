using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilesMiniGame : MonoBehaviour
{
    int randomNumber;
    int lastNumber;
    int maxAttempts = 10;

    void NewRandomNumber()
    {
        for (int i = 0; randomNumber == lastNumber && i < maxAttempts; i++)
        {
            randomNumber = Random.Range(0, 10);
        }
        lastNumber = randomNumber;
    }

    // Start is called before the first frame update
    void Start()
    {
       
       
         //Assign numbers to each button
    }

}
