using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("Test-Level");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
