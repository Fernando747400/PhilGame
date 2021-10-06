using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_UI : MonoBehaviour
{
    [SerializeField] private Text scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = PointSystem.Score.ToString()+"/7";
    }
}
