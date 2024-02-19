using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameColliders : MonoBehaviour
{
    [SerializeField]
    private GameObject miniGameCube;

    public void Start()
    {
        Debug.Log(miniGameCube);

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("who collide with me");

        Debug.Log(collision.collider.gameObject.tag);
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("what to do");
            Debug.Log(miniGameCube);
            miniGameCube.SetActive(true);
        }
    }
}
