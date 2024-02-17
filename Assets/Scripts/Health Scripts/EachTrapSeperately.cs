using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EachTrapSeperately : MonoBehaviour
{
    private GameObject HealthController;
    private void Start()
    {
        HealthController = GameObject.FindGameObjectWithTag("HealthController");
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            HealthController.GetComponent<HealthController>().EachRegularTrapRespond();
        }
    }
}
