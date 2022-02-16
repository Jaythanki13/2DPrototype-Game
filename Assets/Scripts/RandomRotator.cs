using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotator : MonoBehaviour
{
    public static RandomRotator randomRotatorInstance;
    int i, j;
    float resetTimer = 0f;
    //private float startDelay = 2.0f;
    //float speedInterval = 0.5f;

    private void Awake()
    {
        if(randomRotatorInstance == null)
            randomRotatorInstance = this;
    }

    private void Start()
    {
        RandomTime();
    }

    public void RandomTime()
    {
        i = Random.Range(1, 4);
        StartCoroutine("RandomSpeed");
        Debug.Log("RandomTime :- " + i);
        StartCoroutine("HoldSpeed");
    }

    IEnumerator RandomSpeed()
    {
        yield return new WaitForSeconds(i);
        RotateCircle.rotateCircleInstance.rotateSpeed += 80f;
        Debug.Log("rotatorSpeed :- " + RotateCircle.rotateCircleInstance.rotateSpeed);
    }

    IEnumerator HoldSpeed()
    {
        j = Random.Range(1, 7);
        yield return new WaitForSeconds(j);
        //RotateCircle.rotateCircleInstance.rotateSpeed *= -0.8f;
        RandomTime();
        Debug.Log("HoldSpeed Time:- " + j);
    }

    /*public void RandomCategory()
    {
        j = Random.Range(1, 4);
        Debug.Log("RandomCategory :- " + j);
        if (Player.playerInstance.isReached == true)
        {
            RotateCircle.rotateCircleInstance.rotateSpeed -= j;
            Debug.Log("rotatorSpeed :- " + RotateCircle.rotateCircleInstance.rotateSpeed);
        }
    }*/

    /*public void RandomReset()
    {
        resetTimer = 5f;
        Debug.Log("inside RandomReset:- " + resetTimer);
    }*/

    /*public void RandomRotate()
    {
        Debug.Log("inside RandomRotate function");
    }*/
}
