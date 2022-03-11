using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Pisteet : MonoBehaviour
{
    public static Pisteet instance;
    public Text PisteetText;
    int pisteet;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        PisteetText.text = pisteet.ToString();
    }
    // Update is called once per frame
    void Update()
    {

    }
    public void LisaaPisteet() 
    {
        pisteet += 1;
        PisteetText.text = pisteet.ToString()+ " Pisteet";
    }
}
