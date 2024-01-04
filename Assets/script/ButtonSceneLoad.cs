using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonSceneLoad : MonoBehaviour
{
    public static List<string> SceneList = new List<string>() { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

    public void StartGame()
    {
        SceneManager.LoadScene("main");
    }

    public void LoadState()
    {

        SceneManager.LoadScene("state");
    }
    public void resetScene()
    {
        SceneManager.LoadScene("title");
    }


    public void LoadingRandomScene()
    {

        int ran = Random.Range(0, 10);

        if (SceneManager.GetActiveScene().name != SceneList[ran])
        {
            SceneManager.LoadScene(SceneList[ran]);
        }

    }

    public void Exit()
    {
        Application.Quit();
    }

}
