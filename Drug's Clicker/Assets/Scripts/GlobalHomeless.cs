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
    
    void Update()
    {
        currentDrug = GlobalDrug.drugAmount;
        fakeText.GetComponent<Text>().text =  homelessValue +" Drug's - Homeless";
        realText.GetComponent<Text>().text =  homelessValue +" Drug's - Homeless";
        if (currentDrug >= homelessValue)
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
