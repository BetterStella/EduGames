using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem.XR;
using UnityEngine.UI;

public class PlayerActions : MonoBehaviour
{
    private float MoveDirection;
    public int JumpForce=5;
    public int Speed=5;
    Rigidbody2D rb;
    Animator animator;
    [SerializeField] GameObject feet;
    [SerializeField]GameObject rightButton, leftButton;

    [SerializeField] Animation runAnimation;
    [SerializeField] Animation jumpAnimation;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        Movement();
        //Debug.Log(MoveDirection);
        CheckIfButtonsArePressed();
    }

    private void Movement()
    {
        MoveDirection = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(MoveDirection*Speed,rb.velocity.y);
        if(Input.GetButtonDown("Jump"))
        {
            Jump();
        }
        UpdateAnimation();
    }

    public void Jump()
    {
        if(IsGrounded())
        { 
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y + JumpForce);
            //add animation
            //animator.SetBool("", true);
        }
    }

    //TODO - fix isgrounded :)
    private bool IsGrounded()
    {

        if(rb.velocity.y  == 0)
        {
            return true;
        }

        return false;

    }
    
    private void CheckIfButtonsArePressed()
    {
    
        if (Input.GetKeyDown(KeyCode.RightArrow) && !IsGrounded())
        { 
            Debug.Log("right arrow");
            MoveDirection = 1;

        }
        if (Input.GetKeyDown(KeyCode.LeftArrow ) && !IsGrounded())
        {
            Debug.Log("left arrow");

            MoveDirection = -1;

        }

        if (rightButton.GetComponent<MobileMovementButtons>().IsTheButtonBeingPressed() == true)
        {
            MoveDirection = 1;
        }
        if (leftButton.GetComponent<MobileMovementButtons>().IsTheButtonBeingPressed() == true)
        {
            MoveDirection = -1;
        }

        if (rightButton.GetComponent<MobileMovementButtons>().IsTheButtonBeingPressed() && leftButton.GetComponent<MobileMovementButtons>().IsTheButtonBeingPressed())
        {
            MoveDirection = 0;
        }
        if (rightButton.GetComponent<MobileMovementButtons>().IsTheButtonBeingPressed()==false && leftButton.GetComponent<MobileMovementButtons>().IsTheButtonBeingPressed()== false)
        {
            MoveDirection = 0;
        }

        /*
        if(IsOneOfThemTrue)return true;
        else return false;
        */

    }

    private void UpdateAnimation()
    {
        if (MoveDirection > 0)
        {
            animator.SetBool("blondPlayerRun", true);
        }
        if (MoveDirection < 0)
        {
            //run left animation
            animator.SetBool("blondPlayerRunLeft", true);
        }
        if (MoveDirection == 0)
        {
            //idle
            animator.SetBool("blondPlayerIdle", true);
        }
    }


}
