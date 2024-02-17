using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsController : MonoBehaviour
{
    int coinCounter = 0;






    private void IncreaseCounterByValue(int valueToIncrease)
    {
        coinCounter = coinCounter + valueToIncrease;
        Debug.Log("coins :" + coinCounter);
    }






    
    public void EachCoinRespond()
    {
        IncreaseCounterByValue(1);
    }


}
