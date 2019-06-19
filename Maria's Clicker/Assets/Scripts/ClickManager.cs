using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickManager : MonoBehaviour
{
    public GameObject ClickBox;

    public void ClickTheButton()
    {
        ClickBox.SetActive(true);
    }
}
