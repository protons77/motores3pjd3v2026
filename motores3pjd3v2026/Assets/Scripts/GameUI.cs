using UnityEngine;
using TMPro; 
public class GameUI : MonoBehaviour
{
    [SerializeField] private TMP_Text coinText;
    private void OnEnable()
    {
      
        PlayerObserverManager.OnCoinCollected += UpdateCoinDisplay;
    }

    private void OnDisable()
    {
       
        PlayerObserverManager.OnCoinCollected -= UpdateCoinDisplay;
    }

    
    private void UpdateCoinDisplay(int coinCount)
    {
        coinText.text = "Moedas: " + coinCount.ToString();
    }
}