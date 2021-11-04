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

    public event Action<GameObject> SpawnedItem;
    public void newItem(GameObject item)
    {
        SpawnedItem?.Invoke(item);
    }

    public event Action onStartGameplay;

    public void startGameplay()
    {
        onStartGameplay?.Invoke();
    }

    public event Action onGameOver;

    public void finishGameplay()
    {
        onGameOver?.Invoke();
    }

}
