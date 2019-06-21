using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoughtCities : MonoBehaviour
{
    public int priceCity;
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
        }
    }
}
