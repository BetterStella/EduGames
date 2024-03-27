using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
using static Unity.Burst.Intrinsics.X86.Avx;
using UnityEngine.SocialPlatforms.Impl;

public class SlotScript : MonoBehaviour, IDropHandler
{
    [SerializeField]
    private miniGameSO GametoDisplay;
    [SerializeField]
    private GameSO ChosenGame;
    [SerializeField] private AudioSource wrong;
    [SerializeField] private AudioSource success;
    int score = 20;
    private GameObject Tmp;
    MiniGames minigamescript;
    [SerializeField] TextMeshProUGUI scoreText;


    void Start()
    {

        minigamescript = GameObject.FindGameObjectWithTag("minGameFu").GetComponent<MiniGames>();
        GametoDisplay = ChosenGame.Value;
        Debug.Log("Slot game to check:" + GametoDisplay);
        Debug.Log("Slot game to check2:" + ChosenGame.Value);
        Debug.Log("Score:" + score);



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
            score += 5;
            scoreText.text = score.ToString();

            StartCoroutine(ExampleCoroutine(score));



        }
        else
        {
            Debug.Log("The wrong Answer and to add sound and incoragment");
            score -= 5;
            scoreText.text = score.ToString();

            wrong.Play();
        }


        
    }
    IEnumerator ExampleCoroutine(int score)
        {
    
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);
        success.Play();
        yield return new WaitForSeconds(success.clip.length);
        minigamescript.UnloadMiniGame(score);

        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
        }
}
