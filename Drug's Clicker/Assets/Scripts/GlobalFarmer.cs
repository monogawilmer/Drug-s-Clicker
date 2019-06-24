using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalFarmer : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public int currentDrug;
    public static int farmerValue = 1000;
    public static bool turnOffButton = false;
    public GameObject farmerStat;
    public static int numberOfFarmer;
    public static int farmerPerSec;

    void Update()
    {

        currentDrug = GlobalDrug.drugAmount;
        fakeText.GetComponent<Text>().text = farmerValue + " Drug's - " + numberOfFarmer + " Farmer " + farmerPerSec + " Per Sec";
        realText.GetComponent<Text>().text = farmerValue + " Drug's - " + numberOfFarmer + " Farmer " + farmerPerSec + " Per Sec";
        if (currentDrug >= farmerValue)
        {
            fakeButton.SetActive(false);
            realButton.SetActive(true);
        }
        else
        {
            fakeButton.SetActive(true);
            realButton.SetActive(false);
        }

        if (turnOffButton)
        {
            realButton.SetActive(false);
            fakeButton.SetActive(true);
            turnOffButton = false;
        }
    }
}
