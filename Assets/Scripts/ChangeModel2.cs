using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class ChangeModel2 : MonoBehaviour
{
    public TextMeshProUGUI output;
    public GameObject head;

    public void DataInputtedAndHandled(int val)
    {
        if (val == 0)
        {
            head.SetActive(true);
            Debug.Log("Active");
        }
        else if (val == 1)
        {
            head.SetActive(true);
            Debug.Log("Active");
        }
        else if (val == 2)
        {
            head.SetActive(false);
            Debug.Log("Adddctive");
        }
    }
}