using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RotateCircle : MonoBehaviour
{
    public float rotateSpeed = 80f;
    public static RotateCircle rotateCircleInstance;

    private void Awake()
    {
        if(rotateCircleInstance == null)
            rotateCircleInstance = this;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0f, rotateSpeed * Time.deltaTime);
    }
}