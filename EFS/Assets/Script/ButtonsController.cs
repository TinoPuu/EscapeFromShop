using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsController : MonoBehaviour
{
    public AudioSource nappiaani;
    
    void Start()
    {
        nappiaani = GetComponent<AudioSource>();
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        nappiaani.Play();
    }

    public void QuitGame()
    {
        Debug.Log("Quit! (Toimii vaan kun buildaa pelin!)");
        nappiaani.Play();
        Application.Quit();
    }
    public void Menuin() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        nappiaani.Play();

    }
    public void Menuout()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + -2);
        nappiaani.Play();
    }
    public void Playgame2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + -1);
        nappiaani.Play();
    }
    public void Endmenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + -3);
        nappiaani.Play();
    }
    public void WinValikko()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + -4);
        nappiaani.Play();
    }
    public void WinPoistu()
    {
        Debug.Log("Quit! (Toimii vaan kun buildaa pelin!)");
        nappiaani.Play();
        Application.Quit();
    }
}
