using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalHomeless : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public int currentDrug;
    public static int homelessValue = 50;
    public static bool turnOffButton = false;
    public GameObject homelessStat;
    public static int numberOfHomeless;
    public static int homelessPerSec;
    
    void Update()
    {
        currentDrug = GlobalDrug.drugAmount;
        fakeText.GetComponent<Text>().text =  homelessValue +" Drug's - " + numberOfHomeless +" Homeless " + homelessPerSec +" Per Sec";
        realText.GetComponent<Text>().text =  homelessValue +" Drug's - " + numberOfHomeless +" Homeless " + homelessPerSec +" Per Sec";
        if (currentDrug >= homelessValue)
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
