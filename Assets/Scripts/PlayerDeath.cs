using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    //Death functions, pauses when the player touches the deathray. 
    private void OnTriggerEnter2D (Collider2D other)
    {
        if(other.tag=="Player")
        {
            Time.timeScale = 0f;
        }
    }



}