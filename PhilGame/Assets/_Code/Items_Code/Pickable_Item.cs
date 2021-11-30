using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Pickable_Item : MonoBehaviour
{
    [SerializeField] private AudioSource mySound;
    private Vector3 InitialPosition;
    public void Awake()
    {
        InitialPosition = this.transform.position;
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            this.transform.position = InitialPosition;
            PointSystem.Score++;
            mySound.Play();
            this.gameObject.SetActive(false);
            EventsManager.current.pickedItem();
        }
    }

    public void Update()
    {
        this.transform.Rotate(0,40*Time.deltaTime,0);
    }

}
