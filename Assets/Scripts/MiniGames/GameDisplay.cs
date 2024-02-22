using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class GameDisplay : MonoBehaviour
{

    [SerializeField]
    private miniGameSO GametoDisplay;
    public GameObject Tmp;

    // Start is called before the first frame update
    public void Start()
    {
        Tmp = this.transform.GetChild(1).GetChild(0).gameObject;
        Tmp.GetComponent<TextMeshProUGUI>().text = GametoDisplay.A1;
        Tmp = this.transform.GetChild(2).GetChild(0).gameObject;
        Tmp.GetComponent<TextMeshProUGUI>().text = GametoDisplay.A2;
        Tmp = this.transform.GetChild(3).GetChild(0).gameObject;
        Tmp.GetComponent<TextMeshProUGUI>().text = GametoDisplay.A3;
        Tmp = this.transform.GetChild(4).GetChild(0).gameObject;
        Tmp.GetComponent<TextMeshProUGUI>().text = GametoDisplay.A4;
        Tmp = this.transform.GetChild(5).GetChild(0).gameObject;
        Tmp.GetComponent<TextMeshProUGUI>().text = GametoDisplay.Question;
    }

   

}
