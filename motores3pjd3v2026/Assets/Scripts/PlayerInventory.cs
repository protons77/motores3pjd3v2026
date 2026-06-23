using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    private int coins = 0;

    public void AddCoin()
    {
        coins++;
        
        PlayerObserverManager.TriggerCoinCollected(coins);
    }
}