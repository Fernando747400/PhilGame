using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_UI : MonoBehaviour
{
    [SerializeField] private Text scoreText;

    public void Start()
    {
        EventsManager.current.onItemPickup += updateScore;
    }

    public void updateScore()
    {
        scoreText.text = PointSystem.Score.ToString();
    }
}
