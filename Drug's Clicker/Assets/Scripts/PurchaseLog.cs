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
        GlobalHomeless.homelessPerSec += 10*2;
        GlobalHomeless.numberOfHomeless += 1;  
    }

    public void StartStudentDrug()
    {
        autoDrug.SetActive(true);
        GlobalDrug.drugAmount -= GlobalStudent.studentValue;
        GlobalStudent.studentValue *= 2;
        GlobalStudent.turnOffButton = true;
        GlobalStudent.studentPerSec += 50*2;
        GlobalStudent.numberOfStudent += 1;
    }

    public void StartDealerDrug()
    {
        autoDrug.SetActive(true);
        GlobalDrug.drugAmount -= GlobalDealer.dealerValue;
        GlobalDealer.dealerValue *= 3;
        GlobalDealer.turnOffButton = true;
        GlobalDealer.dealerPerSec += 100*2;
        GlobalDealer.numberOfDealer += 1;
    }

    public void StartHitmanDrug()
    {
        autoDrug.SetActive(true);
        GlobalDrug.drugAmount -= GlobalHitman.hitmanValue;
        GlobalHitman.hitmanValue *= 3;
        GlobalHitman.turnOffButton = true;
        GlobalHitman.hitmanPerSec += 500*2;
        GlobalHitman.numberOfHitman += 1;
    }

    public void StartFarmerDrug()
    {
        autoDrug.SetActive(true);
        GlobalDrug.drugAmount -= GlobalFarmer.farmerValue;
        GlobalFarmer.farmerValue *= 4;
        GlobalFarmer.turnOffButton = true;
        GlobalFarmer.farmerPerSec += 1000*2;
        GlobalFarmer.numberOfFarmer += 1;
    }

    public void StartPoliticianDrug()
    {
        autoDrug.SetActive(true);
        GlobalDrug.drugAmount -= GlobalPolitician.politicianValue;
        GlobalPolitician.politicianValue *= 4;
        GlobalPolitician.turnOffButton = true;
        GlobalPolitician.politicianPerSec += 5000*2;
        GlobalPolitician.numberOfPolitician += 1;
    }
}
