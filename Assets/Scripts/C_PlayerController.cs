using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_PlayerController : MonoBehaviour
{
    [SerializeField]
    new public Rigidbody rigidbody;
    public Animator animator;
    public MeshRenderer meshRenderer;
    public Material mat0;
    public Material matL;
    public Material matR;
    public float xHzSpeed = 3;
    //camera movement depends on this
    public float xVeSpeed = 3;
    public float xJumpForce = 3;
    public float thrust = 1000;

    private int pushCounter = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        Animation();
    }

    private void Animation()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        if (horizontalMovement == 0)
        {
            meshRenderer.material = mat0;
        }
        else if (horizontalMovement >= 0)
        {
            meshRenderer.material = matR;
        }
        else if (horizontalMovement <= 0)
        {
            meshRenderer.material = matL;
        }
    }

    private void Movement()
    {
        if (Input.GetButtonDown ("Vertical"))
        {
            pushCounter = pushCounter += 1;
            Debug.Log("pushCounter: " + pushCounter);
        }
        if (pushCounter == 1)
        {
            xVeSpeed = 3.0f; 
        }
        else if (pushCounter == 2)
        {
            xVeSpeed = 6.0f;
        }
        else if (pushCounter == 3)
        {
            xVeSpeed = 9.0f;
        }
        else if (pushCounter == 4)
        {
            xVeSpeed = 12.0f;
        }
        else if (pushCounter == 5)
        {
            xVeSpeed = 15.0f;
        }
        else if (pushCounter == 6)
        {
            xVeSpeed = 18.0f;
        }
        else if (pushCounter == 7)
        {
            xVeSpeed = 21.0f;
        }
        else if (pushCounter == 8)
        {
            xVeSpeed = 24.0f;
        }
        else if (pushCounter == 9)
        {
            xVeSpeed = 27.0f;
        }
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");
        float jumpMovement = Input.GetAxis("Jump");
        Vector3 velocity = new Vector3(horizontalMovement * xHzSpeed, jumpMovement * xJumpForce, verticalMovement * xVeSpeed);
        rigidbody.velocity = velocity;
        if (verticalMovement == 0.0f)
        {
            pushCounter = 0;
        }
        //Vector3 forwardForce = new Vector3(0.0f, 0.0f, verticalMovement *= thrust);
        //rigidbody.AddRelativeForce(forwardForce);
    }
}
