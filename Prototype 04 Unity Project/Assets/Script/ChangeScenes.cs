using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScenes : MonoBehaviour
{
    public void changeToScene(int changeTheScene)
    {
        SceneManager.LoadScene(changeTheScene);
    }

    //This code is for quit the game

    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }

}
