using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // maybe delete this one!!!!!!!!!!!!!!!
    // maybe delete this one!!!!!!!!!!!!!!!
    // maybe delete this one!!!!!!!!!!!!!!!
    // maybe delete this one!!!!!!!!!!!!!!!
    // maybe delete this one!!!!!!!!!!!!!!!
    // maybe delete this one!!!!!!!!!!!!!!!
    // maybe delete this one!!!!!!!!!!!!!!!
    // maybe delete this one!!!!!!!!!!!!!!!
    // maybe delete this one!!!!!!!!!!!!!!!


    int hp;
    GameObject[] inventory = new GameObject[3];

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Trap"))
        {
            TakeDamage();
        }
    }

    private void TakeDamage()
    {
        // TakeDamage(5); from the model
        // changeHp(5); from the view / or should we make it automatic in the view
    }



}
