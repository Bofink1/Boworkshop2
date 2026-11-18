using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    public void LoadGameScene()
    {

        SceneManager.LoadScene("Game");

    }
    public void LoadCreditsScene()
    {

        SceneManager.LoadScene("Credits");

    }
    public void LoadMenuScene()
    {

        SceneManager.LoadScene("Menu");

    }

    public void Quit()
    {
        
        Application.Quit();
        
    }
}
