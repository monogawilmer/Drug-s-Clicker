using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Disaster : MonoBehaviour
{
    public GameObject statusBox;
    public float drugCheck;
    public int genChance;
    public bool disasterActive = false;
    public int drugLoss;

    void Update()
    {
        drugCheck = GlobalDrug.drugAmount / 10;
        if(disasterActive == false)
        {
            StartCoroutine(StarDisaster());
        }
    }

    IEnumerator StarDisaster()
    {
        disasterActive = true;
        genChance = Random.Range(1, 20);
        if(drugCheck >= genChance)
        {
            drugLoss = Mathf.RoundToInt(GlobalDrug.drugAmount * 0.10f);
            statusBox.GetComponent<Text>().text = "You have lost " + drugLoss + " because a laboratory have burned";
            GlobalDrug.drugAmount -= drugLoss;
            //yield return new WaitForSeconds(3);
            statusBox.GetComponent<Animation>().Play("StatusAnim");
            yield return new WaitForSeconds(1);
            statusBox.SetActive(false);
            statusBox.SetActive(true);
        }
        yield return new WaitForSeconds(60);
        disasterActive = false;
    }
}
