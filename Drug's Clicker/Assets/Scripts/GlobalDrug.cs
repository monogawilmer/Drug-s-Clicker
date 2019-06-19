using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalDrug : MonoBehaviour
{
    public static int drugAmount;
    public GameObject drugDisplay;
    public int internalDrug;
    void Update()
    {
        internalDrug = drugAmount;
        drugDisplay.GetComponent<Text>().text = "Drug: " + internalDrug;
    }
}
