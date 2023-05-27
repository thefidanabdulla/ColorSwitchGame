using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    [SerializeField] private GameObject StartButton;
    [SerializeField] private GameObject BackgroundPanel;
    [SerializeField] private GameObject ScoreText;
    [SerializeField] private GameObject GameOverImg;
    [SerializeField] private GameObject RestartButton;
    // Start is called before the first frame update
    void Start()
    {
        GameManager.instance.StopGame();
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameManager.instance.isGamePauseds)
        {
            StartButton.SetActive(false);
            BackgroundPanel.SetActive(false);
            ScoreText.SetActive(true);
            ScoreText.GetComponent<Text>().text = GameManager.instance.score.ToString();
        }
        if (GameManager.instance.isGameOver)
        {
            BackgroundPanel.SetActive(true);
            GameOverImg.SetActive(true);
            RestartButton.SetActive(true);

        }
    }
}
