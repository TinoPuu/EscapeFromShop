using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsController : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Debug.Log("Quit! (Toimii vaan kun buildaa pelin!)");
        Application.Quit();
    }
    public void Menuin() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
    public void Menuout()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + -2);
    }
    public void Playgame2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + -1);
    }
    public void Endmenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + -3);
    }
}
