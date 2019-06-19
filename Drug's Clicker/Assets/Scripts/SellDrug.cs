using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellDrug : MonoBehaviour
{
    public GameObject ClickBox;

    public void ClickTheButton()
    {
        GlobalCash.cashAmount += GlobalDrug.drugAmount;
        GlobalDrug.drugAmount -= GlobalDrug.drugAmount;
        
    }
}
