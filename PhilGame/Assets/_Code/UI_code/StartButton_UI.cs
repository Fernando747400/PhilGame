using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton_UI : MonoBehaviour
{
    [SerializeField] private float xPunchValue = 1.0f;
    [SerializeField] private float yPunchValue = 1.0f;
    [SerializeField] private float zPunchValue = 1.0f;
    [SerializeField] private float timeToAnimate = 1.0f;

    public void Update()
    {
        iTween.PunchScale(this.gameObject, new Vector3(xPunchValue, yPunchValue, zPunchValue), timeToAnimate);
    }
}
