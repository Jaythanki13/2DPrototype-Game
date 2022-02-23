using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Spawner : MonoBehaviour
{
    public static Spawner spawnerInstance;

    public GameObject playerPrefab;
    Touch touch;
    int count = 0;
    int temp = 0;

    private void Awake()
    {
        if (spawnerInstance == null)
        {
            spawnerInstance = this;
        }
    }
    private void Start()
    {
        count = ObjectStack.objectStackInstance.gameobjects.Count;
    }

    void Update()
    {
        if ((Input.touchCount > 0) || Input.GetMouseButtonDown(0))
        {
            if (temp < 40)
            {
                Player.playerInstance.moveBody(ObjectStack.objectStackInstance.gameobjects[0].GetComponent<Rigidbody2D>());
                Score.ballCount--;
                temp++;
                print("Inside if.." + temp);

                Player.playerInstance.isReached = false;

                ObjectStack.objectStackInstance.gameobjects.RemoveAt(0);
                ObjectStack.objectStackInstance.gameobjects.Add(playerPrefab);

                Instantiate(playerPrefab);
                NewPlayerPosition();
            }
        }
    }

    public void NewPlayerPosition()
    {
        for (int i = 0; i < count; i++)
        {
            ObjectStack.objectStackInstance.playerTransform[i].transform.position = new Vector2(0f, -4.07f);
        }
    }

}