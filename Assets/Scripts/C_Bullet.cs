using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_Bullet : MonoBehaviour
{
    public float speed;
    private Vector3 direction;
    //private Vector3 camPos;
    private Vector3 shawtyPos;
    private Vector3 mouseWorldPosition = new Vector3();
    public GameObject shawty;
    private Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        //camPos = cam.transform.position;
        shawtyPos = shawty.transform.position;
        mousePos.z = 1000;
        mouseWorldPosition = cam.ScreenToWorldPoint(mousePos);
        direction = (mouseWorldPosition - shawtyPos).normalized;
        transform.Translate(new Vector3(0, 0, 0) + direction);
        Debug.DrawLine(shawtyPos, direction * 1000, Color.red);
    }
}
