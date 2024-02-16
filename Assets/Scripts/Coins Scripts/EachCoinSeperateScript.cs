using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EachCoinSeperateScript : MonoBehaviour
{
    [SerializeField] GameObject CoinController;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gameObject.SetActive(false);
        }
    }
}
