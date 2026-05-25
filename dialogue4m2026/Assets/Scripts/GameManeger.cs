using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public enum GameState
    {
        Iniciando,
        MenuPrincipal,
        Gameplay
    }

    public GameState currentState;

    // =========================
    // SISTEMA DE MOEDAS
    // =========================
    public int coins = 0;

    private void Awake()
    {
        // Singleton
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // =========================
    // OBSERVER DAS MOEDAS
    // =========================
    private void OnEnable()
    {
        PlayerObserverManager.OnCoinCollected += AddCoin;
    }

    private void OnDisable()
    {
        PlayerObserverManager.OnCoinCollected -= AddCoin;
    }

    void AddCoin()
    {
        coins++;

        Debug.Log("Moedas: " + coins);

        PlayerObserverManagerUI.UpdateCoins(coins);
    }

    private void Start()
    {
        ChangeState(GameState.Iniciando);
        LoadSplash();
    }

    public void ChangeState(GameState newState)
    {
        currentState = newState;
        Debug.Log("Estado atual: " + currentState);
    }

    // =========================
    // CONTROLE DE CENAS
    // =========================

    public void LoadSplash()
    {
        SceneManager.LoadScene("Splash");
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("MenuPrincipal");
        ChangeState(GameState.MenuPrincipal);
    }

    public void LoadGameplay()
    {
        SceneManager.LoadScene("SampleScene");

        // Carrega GUI junto
        SceneManager.LoadScene("GUI", LoadSceneMode.Additive);

        ChangeState(GameState.Gameplay);
    }
}