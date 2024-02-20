using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevel : MonoBehaviour
{
    [SerializeField]
    private GameObject player;



    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("who: ");
        Debug.Log(collision.collider.gameObject.tag);

        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("End of level Reached");
  
        }
    }
}
