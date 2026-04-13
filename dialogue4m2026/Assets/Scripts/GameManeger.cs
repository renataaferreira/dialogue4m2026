using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    // =========================
    // ENUM DE ESTADOS
    // =========================
    public enum GameState
    {
        Iniciando,
        MenuPrincipal,
        Gameplay
    }

    public GameState currentState;

    // =========================
    // SINGLETON
    // =========================
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // não destruir entre cenas
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        SetState(GameState.Iniciando);
        LoadScene("Splash");
    }

    // =========================
    // CONTROLE DE ESTADO
    // =========================
    public void SetState(GameState newState)
    {
        currentState = newState;
        Debug.Log("Estado atual: " + currentState);
    }

    // =========================
    // CONTROLE DE CENAS
    // =========================
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    // =========================
    // BOTÃO JOGAR
    // =========================
    public void StartGame()
    {
        if (currentState == GameState.MenuPrincipal)
        {
            SetState(GameState.Gameplay);
            LoadScene("SampleScene");
        }
    }

    // =========================
    // BOTÃO SAIR
    // =========================
    public void QuitGame()
    {
        Application.Quit();
    }

    // =========================
    // INPUT (SIMPLES)
    // =========================
    public void SetupPlayerInput(PlayerInput playerInput)
    {
        playerInput.ActivateInput();
    }
}