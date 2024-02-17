using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    public bool IsDead = false;

    private int hp;

    private int RegularTrapDamage = 1;
    //TODO - create health bar

    private void Start()
    {
        hp = 5;
    }

    private void TakeDamage(int Damage)
    {
        hp = hp - Damage;
        Debug.Log("hearts number: " + hp);
        //TODO - update helath bar

        if(hp <= 0)
        {
            IsDead = true;
            Debug.Log("dead");
        }
    }

    public void EachRegularTrapRespond()
    {
        TakeDamage(RegularTrapDamage);
    }
}
