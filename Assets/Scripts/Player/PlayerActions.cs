using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PlayerActions : MonoBehaviour
{
    private float MoveDirection;
    public int JumpForce=5;
    public int Speed=5;
    Rigidbody2D rb;
    [SerializeField] GameObject feet;
    [SerializeField]GameObject rightButton, leftButton;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        Movement();
        Debug.Log(MoveDirection);
        CheckIfButtonsArePressed();
    }

    private void Movement()
    {
        //MoveDirection = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(MoveDirection*Speed,rb.velocity.y);
        if(Input.GetButtonDown("Jump"))
        {
            Jump();
        }
    }

    public void Jump()
    {
        if(IsGrounded())
        { 
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y + JumpForce);
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
        //bool IsOneOfThemTrue = false;
        if(rightButton.GetComponent<MobileMovementButtons>().IsTheButtonBeingPressed() == true)
        {
            MoveDirection = 1;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            MoveDirection = 1;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
             MoveDirection = -1;
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









}
