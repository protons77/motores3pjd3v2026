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

    private void Start()
    {
        ChangeState(GameState.Iniciando);
        LoadScene("Splash");
    }

    public void ChangeState(GameState newState)
    {
        currentState = newState;
        Debug.Log("Estado atual: " + currentState);
    }

    public void LoadScene(string sceneName)
    {
        // Controle de acesso ao SceneManager
        if (CanChangeScene(sceneName))
        {
            SceneManager.LoadScene(sceneName);
        }
    }

    private bool CanChangeScene(string sceneName)
    {
        // Regras simples (pode expandir)
        switch (currentState)
        {
            case GameState.Iniciando:
                return true;

            case GameState.MenuPrincipal:
                return true;

            case GameState.Gameplay:
                return true;

            default:
                return false;
        }
    }

    // Botão "Iniciar"
    public void StartGame()
    {
        ChangeState(GameState.Gameplay);
        LoadScene("GetStarted_Scene");
    }

    // Botão "Sair"
    public void QuitGame()
    {
        Application.Quit();
    }
}