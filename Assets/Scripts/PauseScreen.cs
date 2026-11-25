using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PauseScreen: MonoBehaviour
{
    private void Update()
    {
        if (Keyboard.current?.capsLockKey.wasPressedThisFrame == true)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

    public void QuitLevel()
    {
        SceneManager.LoadSceneAsync("MainMenu");
    }

}
