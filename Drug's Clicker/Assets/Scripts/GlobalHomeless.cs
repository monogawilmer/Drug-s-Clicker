using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalHomeless : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public int currentCash;

    void Start()
    {
        
    }

    void Update()
    {
        currentCash = GlobalCash.cashAmount;
    }
}
