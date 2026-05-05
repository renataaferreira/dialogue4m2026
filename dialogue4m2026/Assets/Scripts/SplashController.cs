using UnityEngine;

public class SplashController : MonoBehaviour
{
    void Start()
    {
        Invoke(nameof(IrParaMenu), 2f);
    }

    void IrParaMenu()
    {
        GameManager.Instance.ChangeState(GameManager.GameState.MenuPrincipal);
    }
}