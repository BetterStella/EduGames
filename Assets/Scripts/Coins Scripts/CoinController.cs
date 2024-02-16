using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    int coinCounter = 0;






    private void IncreaseCounterByValue(int valueToIncrease)
    {
        coinCounter = coinCounter + valueToIncrease;
    }



    public void EachCoinRespond()
    {
        IncreaseCounterByValue(1);
    }


}
