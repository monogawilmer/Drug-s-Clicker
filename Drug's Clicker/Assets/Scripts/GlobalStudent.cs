using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GlobalStudent : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public int currentDrug;
    public static int studentValue = 20;
    public static bool turnOffButton = false;
    public GameObject studentStat;
    public static int numberOfStudent;
    public static int studentPerSec;

    void Update()
    {
        currentDrug = GlobalDrug.drugAmount;
        fakeText.GetComponent<Text>().text = studentValue + " Drug's - " + numberOfStudent + " Student " + studentPerSec + " Per Sec";
        realText.GetComponent<Text>().text = studentValue + " Drug's - " + numberOfStudent + " Student " + studentPerSec + " Per Sec";
        if (currentDrug >= studentValue)
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
