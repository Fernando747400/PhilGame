using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver_UI : MonoBehaviour
{
    public GameObject canvas;
    public Text scoreText; 
    void Start()
    {
        EventsManager.current.onGameOver += GameOver;
        this.gameObject.SetActive(false);
    }

    public void GameOver()
    {
        this.gameObject.SetActive(true);
        Vector3 startPos = canvas.transform.position;
        canvas.gameObject.transform.position = new Vector3(0,Screen.height*5,0);
        iTween.MoveTo(canvas.gameObject,startPos, 1.5f);
    }

    public void OnEnable()
    {
        scoreText.text = PointSystem.Score.ToString();
    }

    public void restartGame()
    {
        PointSystem.Score = 0;
        SceneManager.LoadScene("01_Main_Game");
    }

    public void mainMenu()
    {
        SceneManager.LoadScene("00_Main_Menu");
    }
}
