using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    public void LoadNextScene()
    {

        SceneManager.LoadScene("Game");

    }

    public void Quit()
    {
        
        Application.Quit();
        
    }
}
