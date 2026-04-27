using UnityEngine;

public class MenuManager : MonoBehaviour
{
    void Start()
    {
        // Define o estado como MenuPrincipal ao entrar na cena
        GameManager.Instance.SetState(GameManager.GameState.MenuPrincipal);
    }

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