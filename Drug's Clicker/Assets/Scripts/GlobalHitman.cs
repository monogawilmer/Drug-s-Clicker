using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalHitman : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public int currentDrug;
    public static int hitmanValue = 500;
    public static bool turnOffButton = false;
    public GameObject HitmanStat;
    public static int numberOfHitman;
    public static int hitmanPerSec;

    void Update()
    {

        currentDrug = GlobalDrug.drugAmount;
        fakeText.GetComponent<Text>().text = hitmanValue + " Drug's - " + numberOfHitman + " Hitman " + hitmanPerSec + " Per Sec";
        realText.GetComponent<Text>().text = hitmanValue + " Drug's - " + numberOfHitman + " Hitman " + hitmanPerSec + " Per Sec";
        if (currentDrug >= hitmanValue)
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
