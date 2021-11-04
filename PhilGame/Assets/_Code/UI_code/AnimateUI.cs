using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateUI : MonoBehaviour
{
    [SerializeField] private GameObject MainTitle;
    [SerializeField] private GameObject PlayButton;
    private Vector3 InitialPosition;
    private float punch = 0.08f;
    public void Awake()
    {
        InitialPosition = MainTitle.transform.position;
        MainTitle.transform.position = new Vector3(0,Screen.width*5,0);
    }

    public void Start()
    {
        moveIn();
    }

    private void moveIn()
    {
        iTween.MoveTo(MainTitle, InitialPosition, 4f); 
    }

    public void Update()
    {
        iTween.PunchScale(MainTitle,new Vector3(punch,punch,punch),4f);
        iTween.PunchScale(PlayButton, new Vector3(0.1f,0,0), 0.8f);
    }
}
