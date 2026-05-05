using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    // Carrega uma cena pelo nome
    public void LoadScene(string sceneName)
    {
        
        GameManager.Instance.ChangeState(GameManager.GameState.Gameplay);
        GameManager.Instance.LoadScene("GetStarted_Scene");
    }

    // Sai do jogo
    public void QuitGame()
    {
        Debug.Log("Saindo do jogo...");
        Application.Quit();
    }

    // Recarrega a cena atual (opcional)
    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}