using TMPro;
using UnityEngine;

public class CoinIndicator : MonoBehaviour
{
    [SerializeField] private TMP_Text numberOfCoinsText;
    [SerializeField] private CoinManager coinManager;
    
    void Start()
    {
        numberOfCoinsText.text = 0.ToString();
        coinManager.NumberOfCoinsIsChanged += SetNumberOfCoin;
    }

    private void SetNumberOfCoin(float currentNumberOfCoins)
    {
        numberOfCoinsText.text = currentNumberOfCoins.ToString();
    }
}
