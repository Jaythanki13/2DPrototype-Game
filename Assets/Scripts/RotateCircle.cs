using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RotateCircle : MonoBehaviour
{
    public float rotateSpeed = 130f;
    public static RotateCircle rotateCircleInstance;

    private void Awake()
    {
        if(rotateCircleInstance == null)
            rotateCircleInstance = this;
    }

    private void Start()
    {
        //RandomRotator.randomRotatorInstance.RandomTime();
        //StartCoroutine(RotateCircle());
    }

   
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0f, rotateSpeed * Time.deltaTime);
    }
}