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

    private PlayerInput playerInput;

    void Awake()
    {
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

    void Start()
    {
        ChangeState(GameState.Iniciando);
        LoadSplash();
    }
    
    void ChangeState(GameState newState)
    {
        currentState = newState;
        Debug.Log("Estado atual: " + currentState);
    }
    

    void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    void LoadSplash()
    {
        LoadScene("Splash");
    }

    public void GoToMenu()
    {
        if (currentState == GameState.Iniciando)
        {
            ChangeState(GameState.MenuPrincipal);
            LoadScene("MenuPrincipal");
        }
    }

    public void StartGame()
    {
        if (currentState == GameState.MenuPrincipal)
        {
            ChangeState(GameState.Gameplay);
            LoadScene("SampleScene");
        }
    }

    public void QuitGame()
    {
        Debug.Log("Saiu do jogo");
        Application.Quit();
    }
    
    public void AssignPlayerInput(PlayerInput input)
    {
        playerInput = input;
        Debug.Log("Input atribuído ao jogador!");
    }
}