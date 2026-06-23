using UnityEngine;
using UnityEngine.SceneManagement;

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
        SceneManager.LoadScene(sceneName);
    }

    
    public void GoToMenu()
    {
        ChangeState(GameState.MenuPrincipal);
        LoadScene("MenuPrincipal");
    }

    
    public void StartGame()
    {
        ChangeState(GameState.Gameplay);
        LoadScene("GetStarted_Scene");
        
        
        SceneManager.LoadScene("GUI", LoadSceneMode.Additive);
    }

    
    public void QuitGame()
    {
        Application.Quit();
    }
}