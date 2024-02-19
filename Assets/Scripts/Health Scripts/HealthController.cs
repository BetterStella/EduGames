using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    public bool IsDead = false;

    private int hp;

    private GameObject[] Hearts = new GameObject[5];
    [SerializeField]private GameObject Heart1;
    [SerializeField] private GameObject Heart2;
    [SerializeField] private GameObject Heart3;
    [SerializeField] private GameObject Heart4;
    [SerializeField] private GameObject Heart5;
    [SerializeField] private Sprite DeadHeart;


    private int RegularTrapDamage = 1;

    private void Start()
    {
        hp = 5;

        Hearts[0] = Heart1;
        Hearts[1] = Heart2;
        Hearts[2] = Heart3;
        Hearts[3] = Heart4;
        Hearts[4] = Heart5;



    }

    private void TakeDamage(int Damage)
    {
        hp = hp - Damage;
        Debug.Log("hearts number: " + hp);

        UpdateHealthBar();

        if(hp <= 0)
        {
            IsDead = true;
            Debug.Log("dead");
        }
    }

    private void UpdateHealthBar()
    {
        for(int i = 0; i < Hearts.Length; i++)
        {
            if(hp < i+1)
            {
                Hearts[i].GetComponent<Image>().sprite = DeadHeart;
            }
        }
    }



    public void EachRegularTrapRespond()
    {
        TakeDamage(RegularTrapDamage);
    }
}
