using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer_UI : MonoBehaviour
{
    [SerializeField] private Text timerText;
    private float time;
    void Update()
    {
        if (PointSystem.Score < 7)
        {
            time += Time.deltaTime;
            timerText.text = time.ToString();
        }
    }
}
