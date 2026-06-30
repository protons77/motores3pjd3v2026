using System;

public static class PlayerObserverManager
{
    public static event Action OnCoinTriggered;
    
    public static void TriggerCoinTriggered()
    {
        OnCoinTriggered?.Invoke();
    }
    
    public static event Action<int> OnCoinCountChanged;

    public static void TriggerCoinCountChanged(int currentCoins)
    {
        OnCoinCountChanged?.Invoke(currentCoins);
    }
}