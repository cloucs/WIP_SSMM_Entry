using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_BigPumpaShootShoot : MonoBehaviour
{
    public GameObject bullet;
    private Camera cam;
    //private Vector3 camPos;
    private Vector3 pos;
    private Vector3 direction;
    private Vector3 mouseWorldPosition = new Vector3();
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        pos = this.transform.position;
        mousePos.z = 1000;
        mouseWorldPosition = cam.ScreenToWorldPoint(mousePos);
        direction = (mouseWorldPosition - pos).normalized;
        this.transform.rotation = Quaternion.LookRotation(direction);
        //camPos = cam.transform.position;
        Shoot();
    }

    private void Shoot()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            GameObject clone = Instantiate(bullet, pos, Quaternion.identity);
            Destroy(clone, 20.0f);
        }
    }
}
