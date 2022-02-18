using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectStack : MonoBehaviour
{
    public List<GameObject> gameobjects = new List<GameObject>();

    public static ObjectStack objectStackInstance;

    private void Awake()
    {
        if (objectStackInstance == null)
            objectStackInstance = this;
    }
}