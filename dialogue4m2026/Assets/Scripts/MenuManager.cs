using UnityEngine;

public class MenuManager : MonoBehaviour
{
    // BOTÃO JOGAR
    public void Jogar()
    {
        GameManager.Instance.StartGame();
    }

    // BOTÃO SAIR
    public void Sair()
    {
        GameManager.Instance.QuitGame();
    }
}