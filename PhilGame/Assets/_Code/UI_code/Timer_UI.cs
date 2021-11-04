using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer_UI : MonoBehaviour
{
    [SerializeField] private Text timerText;
    private float time = 60;
    private bool isPlaying;

    public void Start()
    {
        isPlaying = false;
        timerText.text = time.ToString();
        EventsManager.current.onStartGameplay += startGame;
        EventsManager.current.onGameOver += endGame;
    }

    void Update()
    {
        updateTimer();
    }

    private void updateTimer()
    {
        if (isPlaying)
        {
            if (time > 0)
            {
                time -= Time.deltaTime;
                timerText.text = Math.Round(time, 0).ToString();
            }
            else if (time <= 0)
            {
                time = 0;
                EventsManager.current.finishGameplay();
            }

        }
    }

    public void startGame()
    {
        isPlaying = true;
    }

    public void endGame()
    {
        isPlaying = false;
    }
}
