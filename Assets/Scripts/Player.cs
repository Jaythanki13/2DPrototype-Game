using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed = 30f;
    [HideInInspector]
    public bool isReached = false;
    public Rigidbody2D rb;
    public static Player playerInstance;

    private void Awake()
    {
        if (playerInstance == null)
            playerInstance = this;
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    /*private void Update()
    {*//*
        if ((Input.GetButtonDown("Jump")) || (Input.GetMouseButtonDown(0)))
        {
            rb.velocity = Vector2.up * speed;
        }
*//*
        if (!isReached)
        {
            Debug.Log("enter");
            rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
        }
    }*/

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "InsideCircle")
        {
            rb.mass = 0f;
            rb.gravityScale = 2f;
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

    public void moveBody(Rigidbody2D rbnew)
    {
        rb = rbnew;
        StartCoroutine(moveRigidBody());
    }

    IEnumerator moveRigidBody()
    {
        while (!isReached)
        {
            yield return null;
            rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
        }
        StopCoroutine(moveRigidBody());
    }
}