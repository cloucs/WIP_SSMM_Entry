using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_CamController : MonoBehaviour
{
    [SerializeField]
    public C_PlayerController playerController;
    new public Rigidbody rigidbody;

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
        float verticalMovement = Input.GetAxis("Vertical");
        Vector3 velocity = new Vector3(0, 0, verticalMovement *= playerController.xVeSpeed);
        rigidbody.velocity = velocity;
    }
}