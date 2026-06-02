using System;
using UnityEngine;

public static class PlayerObserverManager
{
    public static int coins = 0;

    public static Action<int> OnCoinCollected;

    public static void AddCoin()
    {
        coins++;

        Debug.Log("Moedas: " + coins);

        OnCoinCollected?.Invoke(coins);
    }
}