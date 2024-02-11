using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    public static int CoinCounter=0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            CoinCounter++;
            Debug.Log("Coins: " + CoinCounter);
            gameObject.SetActive(false);
        }
    }
}
