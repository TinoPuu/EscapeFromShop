using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class KolikkoPoiminta : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(90 * Time.deltaTime, 0,0);
        transform.Rotate(0, 0, 90 * Time.deltaTime);
        
    }
 
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Pelaajahahmo")
        {
            Destroy(gameObject);
        }
    }
    
}