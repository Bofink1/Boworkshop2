using System;
using System.Threading;
using System.Timers;
using TMPro;
using UnityEngine;

public class TimeDisplay : MonoBehaviour
{
    public TMP_Text timeText;
    public TMP_Text BestTimeText;


   

    private void Awake()
    {
        timeText.text = "Time: " + TimerScript.timer.ToString("0.00");
    }

    
    
}
