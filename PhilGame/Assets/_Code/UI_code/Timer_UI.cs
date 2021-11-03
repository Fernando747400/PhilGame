using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer_UI : MonoBehaviour
{
    [SerializeField] private Text timerText;
    private float time = 60;

    void Update()
    {
        if (time >= 0)
        {
            time -= Time.deltaTime;
            timerText.text = Math.Round(time,0).ToString();
        }
        else
            time = 0;
    }
}
