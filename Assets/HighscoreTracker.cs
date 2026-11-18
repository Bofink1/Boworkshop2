using TMPro;
using UnityEngine;

public class HighscoreTracker : MonoBehaviour
{

    public static TMP_Text textBox;
    private static int attemptNumber = 1;

    public static void AddScore(float score)
    {

        textBox.text += "Atempt " + attemptNumber + ": " + score.ToString("0.00");
        attemptNumber++;
    }

}
