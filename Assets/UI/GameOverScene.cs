using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScene : MonoBehaviour
{
    void Start()
    {
        Cursor.visible = true;
    }

    public void Respawn()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

}