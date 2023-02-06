using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.LowLevel;

public class animationStateController : MonoBehaviour
{
    
  
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetBool("isWalking", true);
        }
        if(Input.GetKeyUp(KeyCode.W))
        {
            animator.SetBool("isWalking", false);
        }
        if (Input.GetKeyDown(KeyCode.LeftShift)  )
        {
            animator.SetBool("isSprint", true);
           
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            animator.SetBool("isSprint", false) ;
        }
       if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("isJumping", true) ;
          
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            animator.SetBool("isJumping", false);

        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetBool("isRight", true);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            animator.SetBool("isRight", false);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetBool("isLeft", true);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            animator.SetBool("isLeft", false);
        }

    }
}
