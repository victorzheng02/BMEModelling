using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class ChangeModel : MonoBehaviour
{
    public TextMeshProUGUI output;
    public GameObject head;

    void HandleInputData(int val)
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
        else if (val == 3)
        {
            head.SetActive(false);
            Debug.Log("Adddctive");
        }
    }
}
