using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Osuma : MonoBehaviour
{
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.name == "Pelaajahahmo")
        {
            Score.Scores += 1;
            Destroy(gameObject);
        }
    }
}
