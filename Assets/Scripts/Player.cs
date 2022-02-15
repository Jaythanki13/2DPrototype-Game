using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed = 50f;
    private bool isReached = false;
    public Rigidbody2D rb;

    private void Start()
    {
        RandomRotator.randomRotatorInstance.RandomTime();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isReached)
        {
            rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "InsideCircle")
        {
            Debug.Log("Inside Trigger Enter");
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
            Debug.Log("Collide to Box");
            collision.GetComponent<Collider2D>().isTrigger = false;
        }
    }

    void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.tag == "Rotator")
        {
            Debug.Log("Inside Trigger Exit");
            coll.GetComponent<Collider2D>().isTrigger = false;
            GetComponent<Collider2D>().isTrigger = false;
        }
    }
}