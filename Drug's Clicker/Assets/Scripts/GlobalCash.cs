using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCash : MonoBehaviour
{
    public static int cashAmount;
    public GameObject cashDisplay;
    public float internalCash;
    void Update()
    {
        
        internalCash = cashAmount;
        if (internalCash < 1000)
        {
            cashDisplay.GetComponent<Text>().text = "Cash \n" + internalCash;
        }
        else if (internalCash >= 1000 && internalCash <= 1000000)
        {
            cashDisplay.GetComponent<Text>().text = "Cash \n" + System.Math.Round(internalCash / 1000, 2) + " Mil";
        }
        else if (internalCash >= 1000000 && internalCash <= 1000000000000)
        {
            cashDisplay.GetComponent<Text>().text = "Cash \n" + System.Math.Round(internalCash / 1000000, 2) + " Millon";
        }
        else if (internalCash >= 1000000000000 && internalCash <= 1000000000000000000)
        {
            cashDisplay.GetComponent<Text>().text = "Cash \n" + System.Math.Round(internalCash / 1000000000000, 2) + " Billon";
        }
        else if (internalCash >= 1000000000000000000)
        {
            cashDisplay.GetComponent<Text>().text = "Cash \n" + System.Math.Round(internalCash / 1000000000000000000, 2) + " Trillon";

        }
    }
}
