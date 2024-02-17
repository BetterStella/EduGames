using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinsController : MonoBehaviour
{
    int coinCounter = 0;
    [SerializeField]TextMeshProUGUI coinText;





    private void IncreaseCounterByValue(int valueToIncrease)
    {
        coinCounter = coinCounter + valueToIncrease;
        coinText.text = coinCounter.ToString();
    }






    
    public void EachCoinRespond()
    {
        IncreaseCounterByValue(1);
    }


}
