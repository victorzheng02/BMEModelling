using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
    public Text gameTimerText;
    float gameTimer=0f;
    int hours = 0;
    int minutes = 0;
    int days = 0;

    void Update() {
        gameTimer += Time.deltaTime;

        if (gameTimer > 0.005){
            gameTimer = 0;
            minutes++;
        }
        if (minutes == 60){
            minutes = 0;
            hours++;
        }
        if (hours == 24){
            hours = 0;
            days++;
        }
        string timerString = "days: " + days.ToString().PadLeft(2,'0') + " hours: " + hours.ToString().PadLeft(2,'0') + " minutes: " +  minutes.ToString().PadLeft(2,'0');

        gameTimerText.text = timerString;
    }
}
