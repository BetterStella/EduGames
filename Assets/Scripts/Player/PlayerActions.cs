using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerActions : MonoBehaviour
{
    private float MoveDirection;
    public int JumpForce=5;
    public int Speed=5;
    Rigidbody2D rb;
    [SerializeField] GameObject feet;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        Movement();
    }

    private void Movement()
    {
        MoveDirection = Input.GetAxis("Horizontal");
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
        /*
        Debug.Log("i got here");
        if (feet.transform.position.y - GameObject.FindGameObjectWithTag("Ground").transform.position.y < 0.3)
        {
            return true;
        }

        return false;
        */
        return true;


    }    









}
