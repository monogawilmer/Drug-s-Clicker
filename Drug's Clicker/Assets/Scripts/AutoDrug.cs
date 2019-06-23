using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDrug : MonoBehaviour
{
    public bool creatingDrug = false;
    public static int drugIncrease = 4;
    public int internalIncrease;
 
    void Update()
    {
        drugIncrease = GlobalHomeless.homelessPerSec + GlobalStudent.studentPerSec + GlobalDealer.dealerPerSec;
        internalIncrease = drugIncrease;
        if (creatingDrug == false)
        {
            creatingDrug = true;
            StartCoroutine(creatingTheDrug());
        }
    }

    IEnumerator creatingTheDrug()
    {
        GlobalDrug.drugAmount += internalIncrease;
        yield return new WaitForSeconds(1);
        creatingDrug = false;
    }
}
