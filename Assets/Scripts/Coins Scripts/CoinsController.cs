using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinsController : MonoBehaviour
{
    [SerializeField]
    private SavedObjects CoinsNo;
    [SerializeField]TextMeshProUGUI coinText;


    private void Start()
    {
        coinText.text = CoinsNo.Value.ToString();
    }

    private void IncreaseCounterByValue(int valueToIncrease)
    {
        CoinsNo.Value += valueToIncrease;
        coinText.text = CoinsNo.Value.ToString();
    }



    
    public void EachCoinRespond()
    {
        IncreaseCounterByValue(1);
    }


}
