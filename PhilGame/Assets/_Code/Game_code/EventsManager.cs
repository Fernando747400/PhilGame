using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EventsManager : MonoBehaviour
{
    public static EventsManager current;

    public void Awake()
    {
        current = this;
    }

    public event Action onItemPickup;

    public void pickedItem()
    {
        onItemPickup?.Invoke();
    }


}
