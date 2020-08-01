using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SimStart : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cam1;
    public GameObject MainCamera;
    public Button button1;
    public void Start()
    {
        Button btn = button1.GetComponent<Button>();
        btn.onClick.AddListener(SwitchRoom);   
    }
    public void SwitchRoom(){
        MainCamera.SetActive(false);
        cam1.SetActive(true);
    }
}
