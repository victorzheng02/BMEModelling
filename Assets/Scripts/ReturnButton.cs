using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReturnButton : MonoBehaviour
{
    public Button button1;
    public GameObject MainCamera;
    public GameObject cam1;

    public void Start()
    {
        Button btn = button1.GetComponent<Button>();
        btn.onClick.AddListener(Returner);   
    }
    void Returner()
    {
        MainCamera.SetActive(true);
        cam1.SetActive(false);
    }
}
