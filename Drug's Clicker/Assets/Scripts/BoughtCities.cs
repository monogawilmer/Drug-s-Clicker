using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoughtCities : MonoBehaviour
{
    public int priceCity;
    public Button button;
    //public GameObject nextCity;
    private int count=0;

    // Start is called before the first frame update
    void Start()
    {
        button.enabled = false;
        var color = button.colors.disabledColor;
    }

    // Update is called once per frame
    void Update()
    {
        if (count==0 && GlobalCash.cashAmount >= priceCity)
            button.enabled = true;
        else if (GlobalCash.cashAmount < priceCity && button.enabled == true && count != 0) 
            button.enabled = false;
        else
        {
            
        }
        
    

    }
    public void ClickTheButton()
    {
        if (GlobalCash.cashAmount>=priceCity)
        {
            
            GlobalCash.cashAmount =GlobalCash.cashAmount - priceCity;
            count += 1;
            var buttonColors = button.image;
            buttonColors.color=Color.green;
            button.enabled=false;
            SellDrug.multiplier += 0.2;
            //nextCity.SetActive(true);
        }
    }
}
