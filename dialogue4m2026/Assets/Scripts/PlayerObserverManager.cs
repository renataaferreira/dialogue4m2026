using System;

public static class PlayerObserverManager
{
    public static Action OnCoinCollected;

    public static void CollectCoin()
    {
        OnCoinCollected?.Invoke();
    }
}