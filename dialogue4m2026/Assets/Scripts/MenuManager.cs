using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        GameManager.Instance.LoadGameplay();
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}