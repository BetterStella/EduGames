using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem.XR;
using UnityEngine.UI;

public class PlayerActions : MonoBehaviour
{
    private float MoveDirection;
    public int JumpForce = 5;
    public int Speed = 5;
    Rigidbody2D rb;
    [SerializeField] GameObject feet;
    [SerializeField] GameObject rightButton, leftButton;

    private Animator anim;

    [SerializeField] private bool IsGrounded = true;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    private void Update()
    {
        if (CheckIfMobileButtonsAreInUse() == false)
        {
            CheckIfPCButtonsArePressed();
        }

        Movement();
        //Debug.Log(MoveDirection);
    }

    private void Movement()
    {
        rb.velocity = new Vector2(MoveDirection * Speed, rb.velocity.y);
        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }
        UpdateAnimation();
    }

    public void Jump()
    {
        if (IsGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y + JumpForce);
        }
    }

    private void CheckIfPCButtonsArePressed()
    {

        if (Input.GetKeyDown(KeyCode.RightArrow) && !IsGrounded)
        {
            Debug.Log("right arrow");
            MoveDirection = 1;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && !IsGrounded)
        {
            Debug.Log("left arrow");

            MoveDirection = -1;
        }

        MoveDirection = Input.GetAxis("Horizontal");
    }


    //check if buttons are pressed, and also put value in movediraction.
    private bool CheckIfMobileButtonsAreInUse()
    {
        if (rightButton.GetComponent<MobileMovementButtons>().IsTheButtonBeingPressed() == true)
        {
            MoveDirection = 1;
            return true;

        }
        if (leftButton.GetComponent<MobileMovementButtons>().IsTheButtonBeingPressed() == true)
        {
            MoveDirection = -1;
            return true;
        }

        if (rightButton.GetComponent<MobileMovementButtons>().IsTheButtonBeingPressed() && leftButton.GetComponent<MobileMovementButtons>().IsTheButtonBeingPressed())
        {
            MoveDirection = 0;
            return true;
        }
        if (rightButton.GetComponent<MobileMovementButtons>().IsTheButtonBeingPressed() == false && leftButton.GetComponent<MobileMovementButtons>().IsTheButtonBeingPressed() == false)
        {
            MoveDirection = 0;
            return false;
        }

        return false;
    }



    private void UpdateAnimation()
    {
        if (MoveDirection > 0)
        {
            anim.SetBool("isRunning", true);
            transform.localScale = new Vector2(1, transform.localScale.y);
        }
        if (MoveDirection < 0)
        {
            anim.SetBool("isRunning", true);
            transform.localScale = new Vector2(-1, transform.localScale.y);
        }
        if (MoveDirection == 0)
        {
            anim.SetBool("isRunning", false);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            IsGrounded = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            IsGrounded = false;
        }
    }


}