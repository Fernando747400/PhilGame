using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    public float secondsToFadeOut;

    public void Start()
    {
        audioSource.volume = 1f;
    }

    public void startGame()
    {
        StartCoroutine(FadeOutMusic());
    }
    public void loadGame()
    {
        SceneManager.LoadScene("01_Main_Game");
    }

    private IEnumerator FadeOutMusic()
    {
        while (audioSource.volume > 0.01f)
        {
            audioSource.volume -= Time.deltaTime / secondsToFadeOut;
            yield return null;
        }
        loadGame();
    }
}
