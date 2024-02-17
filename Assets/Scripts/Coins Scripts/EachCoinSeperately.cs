using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EachCoinSeperately : MonoBehaviour
{
    private GameObject CoinController;
    private void Start()
    {
        CoinController = GameObject.FindGameObjectWithTag("CoinsController");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //letting the coin controller know a coin has been collected
            CoinController.GetComponent<CoinsController>().EachCoinRespond();
            gameObject.SetActive(false);
        }
    }
}
