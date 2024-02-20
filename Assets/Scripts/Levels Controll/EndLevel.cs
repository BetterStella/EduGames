using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour
{
    [SerializeField]
    private GameObject player;

    [SerializeField]
    private int nextLevel;



    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("who: ");
        Debug.Log(collision.collider.gameObject.tag);

        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("End of level Reached");
            OpenNextLevel(nextLevel);

        }
    }

    public void OpenNextLevel(int levelId)
    {
        string levelName = "Level " + levelId;
        if (IsSceneNameExist(levelName))
        {
            SceneManager.LoadScene(levelName);

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
}
