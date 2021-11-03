using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow_UI : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    private Vector3 InitialPotiton;
    public GameObject TargetToLook;
    void Start()
    {
        InitialPotiton = this.transform.position;
        EventsManager.current.SpawnedItem += changeTarget;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = TargetToLook.transform.position;
        targetPosition.y = this.transform.position.y;
        this.gameObject.transform.LookAt(targetPosition);
        this.transform.position = new Vector3(Player.transform.position.x, InitialPotiton.y, Player.transform.position.z + InitialPotiton.z);
    }

    public void changeTarget(GameObject item)
    {
        TargetToLook = item;
    }
}
