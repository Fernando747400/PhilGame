using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickable_Item : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            this.gameObject.SetActive(false);
            PointSystem.Score++;
        }
    }

    public void Update()
    {
        this.transform.Rotate(0,40*Time.deltaTime,0);
    }
}
