﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalHomeless : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public int currentCash;
    public static int homelessValue = 50;
    public static bool turnOffButton = false;
    
    void Update()
    {
        currentCash = GlobalCash.cashAmount;
        fakeText.GetComponent<Text>().text = "Buy Homeless - $" + homelessValue;
        realText.GetComponent<Text>().text = "Buy Homeless - $" + homelessValue;
        if (currentCash >= homelessValue)
        {
            fakeButton.SetActive(false);
            realButton.SetActive(true);
        }

        if (turnOffButton == true)
        {
            realButton.SetActive(false);
            fakeButton.SetActive(true);
            turnOffButton = false;
        }
    }
}
