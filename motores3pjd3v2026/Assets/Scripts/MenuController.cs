using UnityEngine;

public class MenuController : MonoBehaviour
{
    public void OnStartClicked()
    {
        GameManager.Instance.StartGame();
    }

    public void OnQuitClicked()
    {
        GameManager.Instance.QuitGame();
    }
}