using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalPolitician : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public int currentDrug;
    public static int politicianValue = 5000;
    public static bool turnOffButton = false;
    public GameObject politicianStat;
    public static int numberOfPolitician;
    public static int politicianPerSec;

    void Update()
    {

        currentDrug = GlobalDrug.drugAmount;
        fakeText.GetComponent<Text>().text = politicianValue + " Drug's - " + numberOfPolitician + " Politician " + politicianPerSec + " Per Sec";
        realText.GetComponent<Text>().text = politicianValue + " Drug's - " + numberOfPolitician + " Politician " + politicianPerSec + " Per Sec";
        if (currentDrug >= politicianValue)
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
