using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class ChangeModel : MonoBehaviour
{
    public TextMeshProUGUI output;
    public GameObject WoodenTable;
    public GameObject IphoneScreen;
    public GameObject Clothing;
    public GameObject PaperMoney;

    public void HandleInputData(int val)
    {


        if (val == 0)
        {
            WoodenTable.SetActive(false);
            IphoneScreen.SetActive(false);
            Clothing.SetActive(false);
            PaperMoney.SetActive(false);
            Debug.Log("Active");
        }
        else if (val == 1)
        {
            WoodenTable.SetActive(true);
            IphoneScreen.SetActive(false);
            Clothing.SetActive(false);
            PaperMoney.SetActive(false);
            Debug.Log("Active");
        }
        else if (val == 2)
        {
            WoodenTable.SetActive(false);
            IphoneScreen.SetActive(true);
            Clothing.SetActive(false);
            PaperMoney.SetActive(false);
            Debug.Log("Active");
        }
        else if (val == 3)
        {
            WoodenTable.SetActive(false);
            IphoneScreen.SetActive(false);
            Clothing.SetActive(true);
            PaperMoney.SetActive(false);
            Debug.Log("Active");
        }
        else if (val == 4)
        {
            WoodenTable.SetActive(false);
            IphoneScreen.SetActive(false);
            Clothing.SetActive(false);
            PaperMoney.SetActive(true);
            Debug.Log("Active");
        }
    }
}
