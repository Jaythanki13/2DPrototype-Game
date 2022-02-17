using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;

public class Spawner : MonoBehaviour
{
    public static Spawner spawnerInstance;
    public GameObject playerPrefab;
    Touch touch;

    private float waitTime = 0.2f;
    private float nextFire = 0.5f;
    private float myTime = 0.0f;

    private void Awake()
    {
        if (spawnerInstance == null)
        {
            spawnerInstance = this;
        }
    }

    void Update()
    {
        /*for (int i = 0; i < Input.touchCount; ++i)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                Instantiate(playerPrefab, transform.position, transform.rotation);
                Score.ballCount += 1;
            }
        }*/

        myTime = myTime + Time.deltaTime;

        if (Input.GetButton("Fire1") && myTime > nextFire)
        {
            nextFire = myTime + waitTime;
            Instantiate(playerPrefab, transform.position, transform.rotation);
            Score.ballCount += 1;

            nextFire = nextFire - myTime;
            myTime = 0.0f;

        }

        
        /*if ((Input.touchCount == 1) || Input.GetButtonDown("Fire1") && Time.time > shootSpeed)
        {
            Instantiate(playerPrefab, transform.position, transform.rotation);
            Score.ballCount++;
        }*/
    }
}