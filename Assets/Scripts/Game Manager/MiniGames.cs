using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MiniGames : MonoBehaviour
{
    [SerializeField]
    private GameObject player;

    [SerializeField]
    private SavedObjects CoinsNo;

    [SerializeField]
    private GameObject minigame;

    [SerializeField] TextMeshProUGUI coinText;


    [SerializeField]
    private int MiniGame;

    private GameObject miniController;


    private GameObject CoinController;
    private void Start()
    {
        CoinController = GameObject.FindGameObjectWithTag("CoinsController");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("who: ");
        Debug.Log(collision.collider.gameObject.tag);

        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Enter this Game1");
            OpenMiniGame(MiniGame);
        }
    }


    public void OpenMiniGame(int levelId)
    {
        string levelName = "Mini " + levelId;
        Debug.Log(levelName);
        if (IsSceneNameExist(levelName))
        {
            SceneManager.LoadSceneAsync(levelName, LoadSceneMode.Additive);

        }
        else
        {
            SceneManager.LoadScene("End of game");
        }
        // 


    }

    public static bool IsSceneNameExist(string sceneName)
    {
        for (int i = 0; i < SceneManager.sceneCountInBuildSettings; i++)
        {
            var sceneNameInBuildSetting = System.IO.Path.GetFileNameWithoutExtension(SceneUtility.GetScenePathByBuildIndex(i));
            if (sceneNameInBuildSetting.Equals(sceneName))
            {
                return true;
            }
        }
        return false;
    }


    public void UnloadMiniGame()
        {

        //// Get count of loaded Scenes and last index
        //var lastSceneIndex = SceneManager.sceneCount - 1;
        //Debug.Log("I am trying to quit");
        //Debug.Log(lastSceneIndex);


        //// Get last Scene by index in all loaded Scenes
        //var lastLoadedScene = SceneManager.GetSceneAt(lastSceneIndex);
        //Debug.Log(lastLoadedScene);
      

            //SceneManager.UnloadSceneAsync(lastLoadedScene);
            Debug.Log("name of level: ");

            //CoinsNo.Value += 20;
            CoinController.GetComponent<CoinsController>().MiniGameCoinRespond();

            string levelName = "Mini " + MiniGame;
            Debug.Log("name of level: ");
            Debug.Log(levelName);

            SceneManager.UnloadSceneAsync(levelName);

            GameObject[] taggedObjects = GameObject.FindGameObjectsWithTag("miniGameCube");  //Find all GameObjects with specific tag
            string mini = "mini" + MiniGame;
            foreach (GameObject go in taggedObjects)  //iterate through all returned objects, and find the one with the correct name
            {
            if (go.name == mini)
            {
                go.SetActive(false);

                break;
            }
            }



    }

   
}
