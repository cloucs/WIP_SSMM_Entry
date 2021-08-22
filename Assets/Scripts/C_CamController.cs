using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_CamController : MonoBehaviour
{
    public Vector3 camPosition;
    public Transform playerPosition;
    private Vector3 playerVec;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        /*
        Vector3 temp = new Vector3(7.0f,0,0);
        myGameObject.transform.position += temp;
        */
        playerVec.z = playerPosition.position.z;
        transform.position = playerVec + camPosition;
    }
}