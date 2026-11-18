using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
        TimerScript.timerStoped = true;
        SceneManager.LoadScene("Menu");
        HighscoreTracker.AddScore(TimerScript.timer);
    }
}
