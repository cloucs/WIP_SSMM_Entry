using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_PlayerController : MonoBehaviour
{
    [SerializeField]
    new public Rigidbody rigidbody;
    public Animator animator;
    public float xHzSpeed = 3;
    //camera movement depends on this
    public float xVeSpeed = 3;
    public float xJumpForce = 3;

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
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");
        float jumpMovement = Input.GetAxis("Jump");

        Vector3 velocity = new Vector3(horizontalMovement *= xHzSpeed, jumpMovement *= xJumpForce, verticalMovement *= xVeSpeed);
        rigidbody.velocity = velocity;
    }
}
