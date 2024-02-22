using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
using static Unity.Burst.Intrinsics.X86.Avx;


public class SlotScript : MonoBehaviour, IDropHandler
{
    [SerializeField]
    private miniGameSO GametoDisplay;
    private GameObject Tmp;
    MiniGames minigamescript;

    void Start()
    {
        minigamescript = GameObject.FindGameObjectWithTag("minGameFu").GetComponent<MiniGames>();
    }
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop");
        GameObject droppedObject = eventData.pointerDrag;
        Tmp = droppedObject.transform.GetChild(0).gameObject;
        Debug.Log(droppedObject);
        Debug.Log(Tmp);
        Debug.Log(GametoDisplay.CA);
        Debug.Log(Tmp.GetComponent<TextMeshProUGUI>().text);

        if (GametoDisplay.CA == Tmp.GetComponent<TextMeshProUGUI>().text)
        {
            Debug.Log("The right Answer");

            if (eventData.pointerDrag != null)
            {
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            }

            minigamescript.UnloadMiniGame();


        }
        else
        {
            Debug.Log("The wrong Answer and to add sound and incoragment");

        }
       

    }
}
