using UnityEngine;
using TMPro;

public class UI_CoinDisplay : MonoBehaviour
{
    public TextMeshProUGUI coinText;

    private void OnEnable()
    {
        PlayerObserverManagerUI.OnCoinsUpdated += UpdateUI;
    }

    private void OnDisable()
    {
        PlayerObserverManagerUI.OnCoinsUpdated -= UpdateUI;
    }

    void UpdateUI(int total)
    {
        coinText.text = "Moedas: " + total;
    }
}