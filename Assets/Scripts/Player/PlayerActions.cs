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

    private void Movement()
    {
        MoveDirection = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(MoveDirection*Speed,0);
        if(Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y + JumpForce);
        }
    }
    

    
}
