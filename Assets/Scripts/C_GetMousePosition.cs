using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_GetMousePosition : MonoBehaviour
{
    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        Debug.Log(mousePos);
        Instantiate(bullet, mousePos, Quaternion.identity);
    }
}
