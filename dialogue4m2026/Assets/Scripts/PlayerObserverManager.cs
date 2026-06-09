using System;

public static class PlayerObserverManager
{
    // Evento disparado quando uma moeda é coletada
    public static event Action OnCoinCollected;

    // Evento disparado quando a quantidade total muda
    public static event Action<int> OnCoinCountChanged;

    public static void NotifyCoinCollected()
    {
        OnCoinCollected?.Invoke();
    }

    public static void NotifyCoinCountChanged(int totalCoins)
    {
        OnCoinCountChanged?.Invoke(totalCoins);
    }
}