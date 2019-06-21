using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PurchaseLog : MonoBehaviour
{
    public GameObject autoDrug;

    public void StartAutoDrug()
    {
        autoDrug.SetActive(true);
        //Manejo de Homeless
        GlobalDrug.drugAmount -= GlobalHomeless.homelessValue;
        GlobalHomeless.homelessValue *= 2;
        GlobalHomeless.turnOffButton = true;
        GlobalHomeless.homelessPerSec += 2;
        GlobalHomeless.numberOfHomeless += 1;
        //Manejo de Estudiante
        //Manejo de Dealer
        //Manejo de Sicario
        //Manejo de Farmer
        
    }
}
