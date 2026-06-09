using UnityEngine;
using TMPro;

public class CoinUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI coinText;

    private void OnEnable()
    {
        PlayerObserverManager.OnCoinCountChanged += UpdateCoins;
    }

    private void OnDisable()
    {
        PlayerObserverManager.OnCoinCountChanged -= UpdateCoins;
    }

    private void UpdateCoins(int totalCoins)
    {
        coinText.text = "Moedas: " + totalCoins;
    }
}