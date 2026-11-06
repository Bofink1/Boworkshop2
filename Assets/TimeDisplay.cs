using System.Timers;
using TMPro;
using UnityEngine;

public class TimeDisplay : MonoBehaviour
{
    public TMP_Text text;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        text.text = "Best time: " + TimerScript.timer.ToString("0.00");
    }

    // Update is called once per frame
    void Update()
    {
      
            text.text = "Best time: " + TimerScript.timer.ToString("0.00");
        
    }
}
