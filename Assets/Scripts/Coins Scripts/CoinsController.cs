using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(AudioSource))]
public class CoinsController : MonoBehaviour
{
    [SerializeField]
    private SavedObjects CoinsNo;
    [SerializeField]TextMeshProUGUI coinText;

    public AudioClip coinsound;

    private void Start()
    {
        coinText.text = CoinsNo.Value.ToString();
    }

    private void IncreaseCounterByValue(int valueToIncrease)
    {
        AudioSource.PlayClipAtPoint(coinsound, new Vector3(5, 1, 2));

        CoinsNo.Value += valueToIncrease;
        coinText.text = CoinsNo.Value.ToString();
    }


    public void MiniGameCoinRespond()
    {
        IncreaseCounterByValue(20);
    }


    public void EachCoinRespond()
    {
        IncreaseCounterByValue(1);
    }


}
