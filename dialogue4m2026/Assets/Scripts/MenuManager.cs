using UnityEngine;

public class MenuController : MonoBehaviour
{
    void Start()
    {
        GameManager.Instance.SetState(GameManager.GameState.MenuPrincipal);
    }
}