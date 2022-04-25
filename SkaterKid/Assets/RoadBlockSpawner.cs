using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadBlockSpawner : MonoBehaviour
{
    public float maxTime = 1;
    private float timer = 0;
    public GameObject roadBlock;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > maxTime)
        {
            GameObject newroad = Instantiate(roadBlock);
            newroad.transform.position = transform.position;
        }
    }
}
