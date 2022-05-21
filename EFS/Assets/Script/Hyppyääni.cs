using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hyppyääni : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource hyppy;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            hyppy.Play();
        }
    }
}
