using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCash : MonoBehaviour
{
    public static int cashAmount;
    public GameObject cashDisplay;
    public int internalCash;
    void Update()
    {
        
        internalCash = cashAmount;
        cashDisplay.GetComponent<Text>().text = "Cash: " + internalCash;
    }
}
