using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    private float timer;
    public TMP_Text displayText;
    public static bool timerStoped = false;
    void Update()
    {
        if (!timerStoped)
        {
            timer = Time.time;
            displayText.text = timer.ToString("0.00"); 
        }
    }
}
