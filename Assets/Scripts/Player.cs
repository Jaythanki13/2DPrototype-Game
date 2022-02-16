using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed = 30f;
    public bool isReached = false;
    public Rigidbody2D rb;

    public static Player playerInstance;

    private void Awake()
    {
        if (playerInstance == null)
            playerInstance = this;
    }

    // Update is called once per frame
    private void Update()
    {
        if (!isReached)
        {
            rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "InsideCircle")
        {
            rb.mass = 0f;
            rb.gravityScale = 1f;
            isReached = true;
            GetComponent<Collider2D>().isTrigger = false;
        }

        else if (collision.tag == "Obstacle")
        {
            GameManager.gameManagerInstance.RestartGame();
        }

        else if (collision.tag == "Boxes")
        {
            collision.GetComponent<Collider2D>().isTrigger = false;
        }
    }

    private void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.tag == "Rotator")
        {
            coll.GetComponent<Collider2D>().isTrigger = false;
            GetComponent<Collider2D>().isTrigger = false;
        }
    }
}