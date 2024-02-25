using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EachTrapSeperately : MonoBehaviour
{
    [SerializeField][Tooltip("Choose Regular/Deadly\n''Regular'' for traps like ''Spikes''. ''Deadly'' for traps like ''Cliff'',''Water''.")]
    private string trapType = "Regular"; //Regular (spikes) , Deadly (water, cliff).
    private GameObject HealthController;

    [SerializeField]private Animation playerRespondAnimation;
    [SerializeField] private AudioSource HurtRespondAudio;
    private void Start()
    {
        HealthController = GameObject.FindGameObjectWithTag("HealthController");
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            switch (trapType)
            {
                case "Deadly":
                HealthController.GetComponent<HealthController>().EachDeadlyTrapRespond();
                    break;

                default:
                HealthController.GetComponent<HealthController>().EachRegularTrapRespond();
                PlayerReactionToTrap(collision.gameObject);
                    break;
            }
        }
    }

     
    private void PlayerReactionToTrap(GameObject Player)
    {
        int shockWaveForce = 6;
        Rigidbody2D rb = Player.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(rb.velocity.x, shockWaveForce);
        //play hurt animation for player???? but it shouldnt really be here
        //play sound!
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            switch (trapType)
            {
                case "Deadly":
                    HealthController.GetComponent<HealthController>().EachDeadlyTrapRespond();
                    break;

                default:
                    HealthController.GetComponent<HealthController>().EachRegularTrapRespond();
                    PlayerReactionToTrap(collision.gameObject);
                    break;
            }
        }
    }

}
