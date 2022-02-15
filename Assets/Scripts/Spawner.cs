using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;

public class Spawner : MonoBehaviour
{
    public GameObject playerPrefab;

    void Update()
    {
        if ((Input.touchCount > 0) || Input.GetMouseButtonDown(0))
        {
            SpawnPlayer();
        }
    }

    void SpawnPlayer()
    {
        Instantiate(playerPrefab, transform.position, transform.rotation);
        Score.ballCount++;
    }
}