using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{


    
    public static int Scores = 0;
    void Start()
    {
        Scores = 0;
    }

    void Update()
    {
       if(Scores == 11){
           Maali();
       }
    }
    void OnGUI()
    {
        GUI.Label(new Rect(100, 100, 100, 100),Scores.ToString()+ "/5");
    }
    void Maali()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
