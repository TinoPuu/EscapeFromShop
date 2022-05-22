using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static int Scores = 0;
    void Start()
    {
        Scores = 0;
    }

    void Update()
    {
       
    }
    void OnGUI()
    {
        GUI.Label(new Rect(100, 100, 100, 100),Scores.ToString()+ "/5");
    }
}
