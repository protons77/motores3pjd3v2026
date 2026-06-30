using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    private int coins = 0;

    private void OnEnable()
    {
        PlayerObserverManager.OnCoinTriggered += AddCoin;
    }

    private void OnDisable()
    {
        PlayerObserverManager.OnCoinTriggered -= AddCoin;
    }

    private void AddCoin()
    {
        coins++;
        PlayerObserverManager.TriggerCoinCountChanged(coins);
    }
}