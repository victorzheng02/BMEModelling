using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShowValueScript : MonoBehaviour{
    Text valueText;
    // Start is called before the first frame update
    void Start()
    {
        valueText = GetComponent<Text> ();
    }

    // Update is called once per frame  
    public void textUpdate(float value)
    {
        int scale = Mathf.RoundToInt(value*100);
        int temp = Mathf.RoundToInt(scale/9) + 24;
        valueText.text = temp.ToString() + "°C";
    }
}
