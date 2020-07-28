using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
    public Text gameTimerText;
    float gameTimer=0f;


    void Update() {
        gameTimer += Time.deltaTime;

        int seconds = (int)(gameTimer % 60);
        int minutes = (int)(gameTimer / 60) % 60;
        int hours = (int)(gameTimer / 60) % 24;

        string timerString = string.Format("{0:00}:{1:00}:{2:00}",hours,minutes,seconds);

        gameTimerText.text = timerString;
    }
}
