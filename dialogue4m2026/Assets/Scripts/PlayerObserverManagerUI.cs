using System;

public static class PlayerObserverManagerUI
{
    public static Action<int> OnCoinsUpdated;

    public static void UpdateCoins(int total)
    {
        OnCoinsUpdated?.Invoke(total);
    }
}