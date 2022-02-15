using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotator : MonoBehaviour
{
    public static RandomRotator randomRotatorInstance;

    private void Awake()
    {
        randomRotatorInstance = this;
    }

    public void RandomTime()
    {
        int i = Random.Range(0, 5);
        Debug.Log("RandomTime :- " + i);
    }

    public void RandomCategory()
    {
        int j = Random.Range(0, 4);
        Debug.Log("RandomCategory :- " + j);
    }

    public void RandomReset()
    {
        float resetTimer = 5f;
        Debug.Log("inside RandomReset:- " + resetTimer);
    }

    public void RandomRotate()
    {
        Debug.Log("inside RandomRotator");
    }
}
