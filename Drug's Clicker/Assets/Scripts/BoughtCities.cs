using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoughtCities : MonoBehaviour
{
    public int priceCity;

    public GameObject nextCity;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    public void ClickTheButton()
    {
        if (GlobalCash.cashAmount>=priceCity)
        {
            GlobalCash.cashAmount =GlobalCash.cashAmount - priceCity;
            nextCity.SetActive(true);
        }
    }
}
