﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SellDrug : MonoBehaviour
{
    public GameObject ClickBox;
    public GameObject statusBox;
    public void ClickTheButton()
    {
        if (GlobalDrug.drugAmount == 0)
        {
            statusBox.GetComponent<Text>().text = "Not enough drugs to sell";
            statusBox.GetComponent<Animation>().Play("StatusAnim");
        }
        else
        {
            GlobalCash.cashAmount += GlobalDrug.drugAmount;
            GlobalDrug.drugAmount -= GlobalDrug.drugAmount;
        }
    }
}
