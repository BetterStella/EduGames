using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class GameDisplay : MonoBehaviour
{

    [SerializeField]
    private OptionsSO GameO;

 

    private int agerange;
    private int subject;


    [SerializeField]
    private miniGameSO GameToDisplay;

    [SerializeField]
    private GameSO ChosenGame;

    //[SerializeField]
    //private miniGameSO ChosenGame;

    [SerializeField]
    private string correctAnswer1;

    [SerializeField]
    private bool quiz;


    public GameObject Tmp;


    [SerializeField]
    public List<miniGameSO> game = new List<miniGameSO>();

    MiniGames minigamescript;


    // Start is called before the first frame update
    public void Start()
    {

        ChooseGame();
        Debug.Log("Game: " + GameToDisplay);
        Debug.Log("End Game32: " + ChosenGame.Value);
        ChosenGame.Value = GameToDisplay;
        Debug.Log("End Game3: " + ChosenGame.Value);


        Tmp = this.transform.GetChild(1).GetChild(0).gameObject;
        Tmp.GetComponent<TextMeshProUGUI>().text = GameToDisplay.A1;
        if (quiz == true)
        {
            correctAnswer(Tmp, 1);
        }
        Tmp = this.transform.GetChild(2).GetChild(0).gameObject;
        Tmp.GetComponent<TextMeshProUGUI>().text = GameToDisplay.A2;
        if (quiz == true)
        {
            correctAnswer(Tmp, 2);
        }
        Tmp = this.transform.GetChild(3).GetChild(0).gameObject;
        Tmp.GetComponent<TextMeshProUGUI>().text = GameToDisplay.A3;
        if (quiz == true)
        {
            correctAnswer(Tmp, 3);
        }
        Tmp = this.transform.GetChild(4).GetChild(0).gameObject;
        Tmp.GetComponent<TextMeshProUGUI>().text = GameToDisplay.A4;
        if (quiz == true)
        {
            correctAnswer(Tmp, 4);
        }
        Tmp = this.transform.GetChild(5).GetChild(0).gameObject;
        Tmp.GetComponent<TextMeshProUGUI>().text = GameToDisplay.Question;

        minigamescript = GameObject.FindGameObjectWithTag("minGameFu").GetComponent<MiniGames>();

    }

    public void correctAnswer(GameObject Tmp, int a)
    {
        correctAnswer1 = GameToDisplay.CA;
        if (Tmp.GetComponent<TextMeshProUGUI>().text == correctAnswer1)
        {
            Debug.Log("This is the right answer" + a);
            Button btn = this.transform.GetChild(a).GetComponent<Button>();
            btn.onClick.AddListener(TaskOnClick);

        }
        else
        {
            Debug.Log("Not the right answer" + a);


        }
    }

    void TaskOnClick() {
        Debug.Log("to unload the game");
        minigamescript.UnloadMiniGame();

    }
    public void ChooseGame()
    {
        if(game.Count >= 1)
        {
            switch ((agerange, subject))
            {
                case (0, 0):
                    print("Age 0 subject 0");
                    GameToDisplay = game[Random.Range(0, game.Count)];
                    break;
                case (0, 1):
                    print("Age 0 subject 1");
                    GameToDisplay = game[Random.Range(0, game.Count)];

                    break;
                case (0, 2):
                    print("Age 0 subject 2");
                    GameToDisplay = game[Random.Range(0, game.Count)];

                    break;
                case (1, 0):
                    print("Age 1 subject 0");
                    GameToDisplay = game[Random.Range(0, game.Count)];

                    break;
                case (1, 1):
                    print("Age 1 subject 1");
                    GameToDisplay = game[Random.Range(0, game.Count)];

                    break;
                case (1, 2):
                    print("Age 1 subject 2");
                    GameToDisplay = game[Random.Range(0, game.Count)];

                    break;
                case (2, 0):
                    print("Age 2 subject 0");
                    GameToDisplay = game[Random.Range(0, game.Count)];

                    break;
                case (2, 1):
                    print("Age 2 subject 1");
                    GameToDisplay = game[Random.Range(0, game.Count)];

                    break;
                case (2, 2):
                    print("Age 2 subject 2");
                    GameToDisplay = game[Random.Range(0, game.Count)];

                    break;
                case (3, 0):
                    print("Age 3 subject 0");
                    GameToDisplay = game[Random.Range(0, game.Count)];

                    break;
                case (3, 1):
                    print("Age 3 subject 1");
                    GameToDisplay = game[Random.Range(0, game.Count)];

                    break;
                case (3, 2):
                    print("Age 3 subject 2");
                    GameToDisplay = game[Random.Range(0, game.Count)];

                    break;


            }



        }
    }
   

}
