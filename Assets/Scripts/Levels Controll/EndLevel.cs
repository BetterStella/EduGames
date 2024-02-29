using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour
{
    [SerializeField]
    private GameObject player;

    [SerializeField]
    private int nextLevel;

    [SerializeField]
    private SavedObjects CoinsNo;

   [SerializeField] private AudioSource endlevel;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("who: ");
        Debug.Log(collision.collider.gameObject.tag);

        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(ExampleCoroutine());


            Debug.Log("End of level Reached");


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

    IEnumerator ExampleCoroutine()
    {

        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);
        endlevel.Play();
        yield return new WaitForSeconds(endlevel.clip.length);

        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
        OpenNextLevel(nextLevel);

       
    }
}
