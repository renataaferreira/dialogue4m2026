using UnityEngine;

public class SplashController : MonoBehaviour
{
    void Start()
    {
        Invoke("IrParaMenu", 2f); // espera 2 segundos
    }

    void IrParaMenu()
    {
        GameManager.Instance.SetState(GameManager.GameState.MenuPrincipal);
        GameManager.Instance.LoadScene("MenuPrincipal");
    }
}
