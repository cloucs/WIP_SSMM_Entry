using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_RoadSpawner : MonoBehaviour
{
    public GameObject road;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 1000; i++)
        {
            Instantiate(road, new Vector3(0, 0, i * 10.0F), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
