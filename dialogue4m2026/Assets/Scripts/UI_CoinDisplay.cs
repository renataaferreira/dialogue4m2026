using TMPro;
using UnityEngine;

public class UI_CoinDisplay : MonoBehaviour
{
    public TextMeshProUGUI coinText;

    private void OnEnable()
    {
        PlayerObserverManager.OnCoinCollected += UpdateUI;
    }

    private void OnDisable()
    {
        PlayerObserverManager.OnCoinCollected -= UpdateUI;
    }

    void UpdateUI(int totalCoins)
    {
        coinText.text = "Moedas: " + totalCoins;
    }
}