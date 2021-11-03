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
    public event Action<GameObject> SpawnedItem;

    public void pickedItem()
    {
        onItemPickup?.Invoke();
    }

    public void newItem(GameObject item)
    {
        SpawnedItem?.Invoke(item);
    }

}
