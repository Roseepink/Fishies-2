using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu_GUI : MonoBehaviour

{
    public void PlayGame()
    {
        SceneManager.LoadScene(1); //Put your scene number in the brackets here. You can find your scene numbers in Build Settings
    }

    public void QuitGame() //Quits the application.
    {
        Debug.Log("Quit!");
        Application.Quit();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);

    }
}