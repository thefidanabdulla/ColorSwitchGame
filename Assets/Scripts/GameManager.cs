using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    #region
    public static GameManager instance = null;
    private void Awake()
    {
        if (instance == null) instance = this;
        else DontDestroyOnLoad(instance);
    }
    #endregion
    public int score;
    public bool isGameOver;
    public bool isGamePauseds = true;

    public void ScoreIncrease()
    {
        score++;
    }

    public void GameOver()
    {
        isGameOver = true;
        Time.timeScale = 0.0f;
    }

    public void StopGame()
    {
        Time.timeScale = 0.0f;
        isGamePauseds = true;
    }

    public void ContinueGame()
    {
        isGamePauseds = false;
        Time.timeScale = 1.0f;
    }

    public void RestartGame()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.buildIndex);
    }
}

