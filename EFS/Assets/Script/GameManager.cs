using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] 
    Text scoreText;
    [SerializeField]
    Text missionText;
    public static int Scores = 0;
    // Start is called before the first frame update

    public void increasePoints()
    {
        Scores += 1;
        scoreText.text = "Hedelmät/Vihannekset: " + Scores + "/5";
        if (Scores == 5)
        {
            missionText.text = "Pakene kaupasta!";
        }
        
       
    }

    
}
