using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Itemspawner : MonoBehaviour
{
    public Transform[] SpawnPoints;
    public GameObject[] ItemsToSpawn;
    private int LastChoosenSpawn = 0;
    private int CurrentChoosenSpawn;
    private GameObject ChoosenItem;

    public void Start()
    {
        SubscibeEvent();
        SpawnItem();
    }

    public void SpawnItem()
    {
        ChoosenItem = pickRandomItem(ItemsToSpawn);
        ChoosenItem.SetActive(true);
        ChoosenItem.transform.position = pickRandomSpawn(SpawnPoints).position;
        EventsManager.current.newItem(ChoosenItem);
    }

    public void SubscibeEvent()
    {
        EventsManager.current.onItemPickup += SpawnItem;
    }
    
    private GameObject pickRandomItem(GameObject[] itemList)
    {
        if (itemList.Length >= 2)
        {
            return itemList[Random.Range(0, itemList.Length)];
        }
        else
            return itemList[0];
    }

    private Transform pickRandomSpawn(Transform[] spawnList) //this prevents an item from appearing on the same spot twice in a row. 
    {
        if (spawnList.Length >= 2)
        {
            do
            {
                CurrentChoosenSpawn = Random.Range(0, spawnList.Length);
            } while (CurrentChoosenSpawn == LastChoosenSpawn);
            LastChoosenSpawn = CurrentChoosenSpawn;
            return spawnList[CurrentChoosenSpawn];
        }
        else
            return spawnList[0];
    }
}
