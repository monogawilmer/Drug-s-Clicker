using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;

public class SellDrug : MonoBehaviour
{
    public GameObject ClickBox;
    public GameObject statusBox;
    public GameObject particles;
    public AudioClip celebrationAudioClip;
    private ParticleSystem particle;
    public AudioClip register;
    private AudioSource celebration;
    public static double multiplier=1;


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
            celebration.PlayOneShot(register);
            celebration.PlayOneShot(celebrationAudioClip, 2f);
            double amountCashFloat = (GlobalDrug.drugAmount*multiplier);
            int amountCash = Convert.ToInt32(amountCashFloat);
            GlobalCash.cashAmount += Convert.ToInt32(amountCashFloat);;
            GlobalDrug.drugAmount -= GlobalDrug.drugAmount;
            if (particles.GetComponent<ParticleSystem>().isPlaying == false)
            {
                var emision = particle.emission;
                emision.rateOverTime = amountCash ;
                particles.SetActive(true);
            }
        }  
    }
}
