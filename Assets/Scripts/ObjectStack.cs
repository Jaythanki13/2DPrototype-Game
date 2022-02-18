using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectStack : MonoBehaviour
{
    public List<GameObject> gameobjects = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < gameobjects.Count; i++)
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
