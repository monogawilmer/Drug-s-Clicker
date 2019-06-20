using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SellDrug : MonoBehaviour
{
    public GameObject ClickBox;
    public GameObject statusBox;
    public GameObject particles;
    private ParticleSystem particle;


    private void Start()
    {
        particle = particles.GetComponent<ParticleSystem>();
    } 
    public void ClickTheButton()
    {
        if (GlobalDrug.drugAmount == 0)
        {
            statusBox.GetComponent<Text>().text = "Not enough drugs to sell";
            statusBox.GetComponent<Animation>().Play("StatusAnim");
        }
        else
        {
            int b = GlobalDrug.drugAmount;
            GlobalCash.cashAmount += GlobalDrug.drugAmount;
            GlobalDrug.drugAmount -= GlobalDrug.drugAmount;
            if (particles.GetComponent<ParticleSystem>().isPlaying == false)
            {
                var emision = particle.emission;
                emision.rateOverTime = b ;
                particles.SetActive(true);
            }
        }  
    }
}
