using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMove : MonoBehaviour
{
    [SerializeField] float jumpPower = 5f;
    [SerializeField] float walkSpeed = 10f;
    
  Vector2 moveInput;
    Rigidbody myRigidbody;
    bool isGrounded = true;
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Run();
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            Jump();
        }
    
    }
    void Run()
    {
        Vector3 playerVelocity = new Vector3(moveInput.x * walkSpeed, myRigidbody.velocity.y, moveInput.y * walkSpeed);
        myRigidbody.velocity = transform.TransformDirection(playerVelocity);
        if (Input.GetKeyDown(KeyCode.LeftShift) && isGrounded)
        {
            walkSpeed = 15f;
        }
     
            if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            walkSpeed = 10;
                }
    }
   
    void Jump()
    {
        myRigidbody.AddForce(new Vector3(0, jumpPower, 0), ForceMode.Impulse);
        isGrounded = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Grounded")
        {
            isGrounded = true;
        }
    }

    void OnMove(InputValue value)
    {
        
        moveInput = value.Get<Vector2>();

    }
    
}



