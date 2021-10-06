using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    private Vector3 InitialPotiton;
    void Start()
    {
        InitialPotiton = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(Player.transform.position.x,InitialPotiton.y,Player.transform.position.z + InitialPotiton.z);
    }
}
