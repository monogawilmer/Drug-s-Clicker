using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalDealer : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public int currentDrug;
    public static int dealerValue = 100;
    public static bool turnOffButton = false;
    public GameObject dealerStat;
    public static int numberOfDealer;
    public static int dealerPerSec;

    void Update()
    {
        
        currentDrug = GlobalDrug.drugAmount;
        fakeText.GetComponent<Text>().text = dealerValue + " Drug's - " + numberOfDealer + " Dealer " + dealerPerSec + " Per Sec";
        realText.GetComponent<Text>().text = dealerValue + " Drug's - " + numberOfDealer + " Dealer " + dealerPerSec + " Per Sec";
        if (currentDrug >= dealerValue)
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
