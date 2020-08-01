using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    public GameObject cam1;
    public GameObject MainCamera;
    public void CameraMenu(int val)
    {
    
        if (val == 0)
        {
            MainCamera.SetActive(true);
            cam1.SetActive(false);
        }
        else if (val == 1)
        {
            MainCamera.SetActive(false);
            cam1.SetActive(true);
        }
        else if (val == 2)
        {
            MainCamera.SetActive(false);
            cam1.SetActive(true);
        }
        else if (val == 3)
        {
            MainCamera.SetActive(false);
            cam1.SetActive(true);
        }
        else if (val == 4)
        {
            MainCamera.SetActive(false);
            cam1.SetActive(true);
        }
    }
}
