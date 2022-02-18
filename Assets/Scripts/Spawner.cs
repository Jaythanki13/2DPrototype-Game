using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Spawner : MonoBehaviour
{
    public static Spawner spawnerInstance;
    public GameObject playerPrefab;
    Touch touch;

    /*private float waitTime = 0.2f;
    private float nextFire = 0.5f;
    private float myTime = 0.0f;*/

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

        /*myTime = myTime + Time.deltaTime;

        if (Input.GetButton("Fire1") && myTime > nextFire)
        {
            nextFire = myTime + waitTime;
            Instantiate(playerPrefab, transform.position, transform.rotation);
            Score.ballCount -= 1;
            nextFire = nextFire - myTime;
            myTime = 0.0f;

            if (Score.ballCount == 0)
            {
                SceneManager.LoadScene("WinScene");
            }
        }*/

        
        if ((Input.touchCount > 0) || Input.GetMouseButtonDown(0))
        {
            Instantiate(playerPrefab, transform.position, transform.rotation);
            Score.ballCount--;

            if (Score.ballCount == 0)
            {
                SceneManager.LoadScene("WinScene");
            }
        }
    }
}