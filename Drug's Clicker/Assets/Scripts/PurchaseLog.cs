using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PurchaseLog : MonoBehaviour
{
    public GameObject autoDrug;

    public void StartAutoDrug()
    {
        autoDrug.SetActive(true);
        GlobalDrug.drugAmount -= GlobalHomeless.homelessValue;
        GlobalHomeless.homelessValue *= 2;
        GlobalHomeless.turnOffButton = true;
        GlobalHomeless.homelessPerSec += 2;
        GlobalHomeless.numberOfHomeless += 1;  
        //Manejo de Dealer
        //Manejo de Sicario
        //Manejo de Farmer
    }

    public void StartStudentDrug()
    {
        autoDrug.SetActive(true);
        GlobalDrug.drugAmount -= GlobalStudent.studentValue;
        GlobalStudent.studentValue *= 3;
        GlobalStudent.turnOffButton = true;
        GlobalStudent.studentPerSec += 5;
        GlobalStudent.numberOfStudent += 1;
    }

    public void StartDealerDrug()
    {
        autoDrug.SetActive(true);
        GlobalDrug.drugAmount -= GlobalDealer.dealerValue;
        GlobalDealer.dealerValue *= 4;
        GlobalDealer.turnOffButton = true;
        GlobalDealer.dealerPerSec += 15;
        GlobalDealer.numberOfDealer += 1;
    }
}
