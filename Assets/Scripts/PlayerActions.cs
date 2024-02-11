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

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        Movement();
    }


    //not working. i didnt manage to get the buttons to work?!! it sopposed to get value from the buttons but i need to check if the buttons are pushed down, not just if they have been clicked!
    public void DirectionGotFromButtons(float directionGetFromButton)
    {
        MoveDirection = directionGetFromButton;
    }

    private void Movement()
    {
        MoveDirection = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(MoveDirection*Speed,0);
        if(Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x,JumpForce);
        }
    }
    

    
}
