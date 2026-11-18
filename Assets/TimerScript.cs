using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    public static float timer;
    public TMP_Text displayText;
    public static bool timerStoped;

    private void Awake()
    {
        timerStoped = false;
        timer = 0;
    }

    void Update()
    {
        if (!timerStoped)
        {
            timer += Time.deltaTime;
            displayText.text = timer.ToString("0.00"); 
        }

      
    }
    
}
