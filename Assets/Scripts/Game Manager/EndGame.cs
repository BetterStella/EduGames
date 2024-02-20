using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EndGame : MonoBehaviour
{

    [SerializeField]
    private SavedObjects CoinsNo;

    [SerializeField] TextMeshProUGUI CoinText2;

    private void Start()
    {
        CoinText2.text = CoinsNo.Value.ToString();
   
    }
}
