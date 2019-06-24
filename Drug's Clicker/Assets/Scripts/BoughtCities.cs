using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BoughtCities : MonoBehaviour
{
    public int priceCity;

    public Button button;

    //public GameObject nextCity;
    private int count = 0;
    public GameObject multiplierText;

    // Start is called before the first frame update
    void Start()
    {
        button.enabled = false;
        var color = button.colors.disabledColor;
    }

    // Update is called once per frame
    void Update()
    {
        var buttonColors = button.image;

        if (count == 0 && GlobalCash.cashAmount >= priceCity)
        {
            button.enabled = true;
            buttonColors.color = Color.yellow;
        }
        else if (GlobalCash.cashAmount < priceCity && button.enabled == true && count != 0)
        {
            button.enabled = false;
            buttonColors.color=Color.white;
            
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
            SellDrug.multiplier += 0.35;
            multiplierText.GetComponent<Text>().text = "multiplier x" + SellDrug.multiplier;
            //nextCity.SetActive(true);
        }
    }
}
