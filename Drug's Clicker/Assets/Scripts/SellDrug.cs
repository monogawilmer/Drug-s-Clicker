using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SellDrug : MonoBehaviour
{
    public GameObject ClickBox;
    public GameObject statusBox;
    public GameObject particles;
    public AudioClip celebrationAudioClip;
    private ParticleSystem particle;
    private AudioSource celebration;
    


    private void Start()
    {
        particle = particles.GetComponent<ParticleSystem>();
        celebration = GetComponent<AudioSource>();
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
            celebration.PlayOneShot(celebrationAudioClip, 2f);
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
