using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamera : MonoBehaviour
{
    // Start is called before the first frame update
    public bool inArea = false;
    public bool dead = false;
    float time = 0.0f;
    float interpolationPeriod = 5.0f;
    bool camLightsOn = true;

    public AudioSource kamera;

    void Start()
    {
        kamera = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Kamerat();
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            inArea = true;
            Debug.Log("Kamera-alueen sis‰ll‰");
            kamera.Play();
        }
    }
    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            inArea = false;
            Debug.Log("Kamera-alueen ulkona");

        }
    }
    void Kamerat()
    {
       
        GameObject[] CamLights = GameObject.FindGameObjectsWithTag("Valo");
        GameObject[] SpotLights = GameObject.FindGameObjectsWithTag("Spottivalo");
        time += Time.deltaTime;

        if (inArea == true && camLightsOn == true)
        {
            dead = true;
            Debug.Log("Kuoli");
        }
        if (time >= interpolationPeriod)
        {
            time = time - interpolationPeriod;
            if (camLightsOn == true)
            {
                foreach (GameObject cl in CamLights)
                {
                    cl.GetComponent<Renderer>().enabled = false;

                }
                foreach (GameObject sl in SpotLights)
                {
                    sl.GetComponent<Light>().enabled = false;

                }


                camLightsOn = false;
                Debug.Log("Kamerat pois p‰‰lt‰");
            }
            else
            {

                foreach (GameObject cl in CamLights)
                {
                    cl.GetComponent<Renderer>().enabled = true;

                }
                foreach (GameObject sl in SpotLights)
                {
                    sl.GetComponent<Light>().enabled = true;

                }

                camLightsOn = true;
                Debug.Log("Kamerat p‰‰ll‰");
            }

        }
    }
}
