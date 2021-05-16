using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
        public void PlayGame()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            FindObjectOfType<AudioScript>().Play("selectmenu");

    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    // Load specific level ( level menu ) 
    public void LoadLevelOne()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void LoadLevelTwo()
    {
        SceneManager.LoadScene("Level02");
    }
    public void LoadLevelThree()
    {
        SceneManager.LoadScene("Level03");
    }


}
