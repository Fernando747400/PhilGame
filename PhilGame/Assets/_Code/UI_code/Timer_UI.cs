using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer_UI : MonoBehaviour
{
    [SerializeField] private Text timerText;
    [SerializeField] private AudioSource myAudio;
    private float time = 60;
    private bool isPlaying;

    public void Start()
    {
        isPlaying = false;
        timerText.text = time.ToString();
        EventsManager.current.onStartGameplay += startGame;
        EventsManager.current.onGameOver += endGame;
        EventsManager.current.onItemPickup += addTime;
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
                if (!myAudio.isPlaying)
                {
                    myAudio.Play();
                }
            }
            else if (time <= 0)
            {
                time = 0;
                EventsManager.current.finishGameplay();
            }

            if(time <= 10)
            {
                myAudio.pitch = 1.3f;
            } else if (time > 10)
            {
                myAudio.pitch = 1;
            }
        }
        if (time <= 0)
        {
            myAudio.pitch = 1;
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

    public void addTime()
    {
        time = time + 2;
    }
}
