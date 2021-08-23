using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_BossAnimation : MonoBehaviour
{
    //adjust this to change speed
    public float speed = 5f;
    //adjust this to change how high it goes
    public float height = 0.5f;
    // Start is called before the first frame update
    private Vector3 newPos;
    void Start()
    {
    }
 
    void Update() 
    {
        //get the objects current position and put it in a variable so we can access it later with less code
        Vector3 pos = this.transform.position;
        //calculate what the new Y position will be
        float newY = Mathf.Sin(Time.time * speed);
        //set the object's Y to the new calculated Y
        this.transform.position = new Vector3(pos.x, newY, pos.z) * height;
    }
}
