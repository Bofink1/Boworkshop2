using System;
using System.Timers;
using TMPro;
using UnityEngine;

public class TimeDisplay : MonoBehaviour
{
    public TMP_Text timeText;
    public TMP_Text BestTimeText;
    private float lastTime;
    private float bestTime = 9999999999999999999;
  
   

    private void Awake()
    {
        lastTime = TimerScript.timer;
        if (lastTime < bestTime)
        {
            bestTime = lastTime;
            BestTimeText.text = "Best time: " + bestTime.ToString("0.00");
        }
        timeText.text = "Time: " + TimerScript.timer.ToString("0.00");
    }

    
    
}
