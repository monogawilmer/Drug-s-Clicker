using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PurchaseLog : MonoBehaviour
{
    public GameObject autoDrug;

    public void StartAutoDrug()
    {
        autoDrug.SetActive(true);
        GlobalCash.cashAmount -= GlobalHomeless.homelessValue;
        GlobalHomeless.homelessValue *= 2;
        GlobalHomeless.turnOffButton = true;
    }
}
