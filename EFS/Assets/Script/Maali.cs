using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Maali : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (GameManager.Scores == 5)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;
        }
    }
}
