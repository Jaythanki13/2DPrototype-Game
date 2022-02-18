using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotator : MonoBehaviour
{
    public static RandomRotator randomRotatorInstance;
    int i, j, k;

    private void Awake()
    {
        if(randomRotatorInstance == null)
            randomRotatorInstance = this;
    }

    private void Start()
    {
        RandomTime();
        //RandomCategory();
    }

    public void RandomTime()
    {
        i = Random.Range(1, 4); //Get Random time
        StartCoroutine("RandomSpeed"); //Get speed to increase
    }

    IEnumerator RandomSpeed()
    {
        yield return new WaitForSeconds(i);
        RotateCircle.rotateCircleInstance.rotateSpeed += 30f; //increase speed after getting Random Time
        StartCoroutine("HoldSpeed");//Goes into HoldSpeed where it will hold for seconds
    }

    IEnumerator HoldSpeed()
    {
        j = Random.Range(1, 4);
        yield return new WaitForSeconds(j); //Will Hold for seconds get in j
        StartCoroutine("RandomCategory");//will start calling this function
    }

    IEnumerator RandomCategory()
    {
        yield return null;
        k = Random.Range(0, 4); //will get any one value between this and will go into switch case

        switch (k)
        {
            case 0: //Anti Clockwise Rotation of Circle
                RotateCircle.rotateCircleInstance.rotateSpeed *= (-0.5f);
                break;

            case 1: //Clockwise Rotation of Circle
                RotateCircle.rotateCircleInstance.rotateSpeed *= 1.2f;
                break;

            case 2: //Speed Decrease
                int d = Random.Range(10, 20);
                RotateCircle.rotateCircleInstance.rotateSpeed -= d;
                break;

            case 3: //Speed Increase
                int s = Random.Range(30, 50);
                RotateCircle.rotateCircleInstance.rotateSpeed += s;
                break;
        }

        StartCoroutine("HoldSpeed");
    }
}