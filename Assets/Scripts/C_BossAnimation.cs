using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_BossAnimation : MonoBehaviour
{
    //adjust this to change speed
    public float speed = 5f;
    //adjust this to change how high it goes
    public float height = 0.5f;
    public Transform gObj;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("pos: " + gObj.transform.position);
        Vector3 startPos = new Vector3(0, 15.0f, 26.0f);
        gObj.position = startPos;
    }
 
    void Update() 
    {
        //get the objects current position and put it in a variable so we can access it later with less code
        Debug.Log("pos: " + gObj.transform.position);
        Vector3 pos = gObj.position;
        //calculate what the new Y position will be
        float newY = Mathf.Sin(Time.time * speed);
        //set the object's Y to the new calculated Y
        gObj.position = new Vector3(pos.x, newY, pos.z) * height;
    }
}
