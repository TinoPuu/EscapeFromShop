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
        //Toimii vaan kun buildaa pelin!
        Debug.Log("Quit! (Toimii vaan kun buildaa pelin!)");
        Application.Quit();
    }
}
