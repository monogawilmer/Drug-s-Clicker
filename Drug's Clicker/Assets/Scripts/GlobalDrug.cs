using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalDrug : MonoBehaviour
{
    public static int drugAmount;
    public GameObject drugDisplay;
    public float internalDrug;
    void Update()
    {
        internalDrug = drugAmount;
        if(internalDrug < 1000)
        {
            drugDisplay.GetComponent<Text>().text = "Drug \n" + internalDrug;
        }
        else if (internalDrug >= 1000 && internalDrug <= 1000000)
        {
            drugDisplay.GetComponent<Text>().text = "Drug \n" + System.Math.Round(internalDrug /1000,2) + " Mil";
        }
        else if (internalDrug >= 1000000 && internalDrug <= 1000000000000)
        {
            drugDisplay.GetComponent<Text>().text = "Drug \n" + System.Math.Round(internalDrug / 1000000, 2) + " Millon";
        }
        else if(internalDrug >= 1000000000000 && internalDrug <= 1000000000000000000)
        {
            drugDisplay.GetComponent<Text>().text = "Drug \n" + System.Math.Round(internalDrug / 1000000000000, 2) + " Billon";
        }
        else if(internalDrug >= 1000000000000000000)
        {
            drugDisplay.GetComponent<Text>().text = "Drug \n" + System.Math.Round(internalDrug / 1000000000000000000, 2) + " Trillon";

        }
    }
}
