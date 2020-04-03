using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    public void PlayGame()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);//get into the next scene that is set in the settings
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("QUIT");//this is for supporting the quitting of the game
    }
}
