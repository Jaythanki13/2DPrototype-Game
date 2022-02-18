using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManagerInstance;
    public Rigidbody2D rb;
    private void Awake()
    {
        if(gameManagerInstance == null)
            gameManagerInstance = this;
    }

    /*private void Update()
    {
        if (!Player.playerInstance.isReached)
        {
            //Debug.Log("inside isReached");
            rb.MovePosition(rb.position + Vector2.up * Player.playerInstance.speed * Time.deltaTime);
        }
    }*/

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Score.ballCount = 0;
    }
}