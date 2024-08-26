using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class AutoCoinAssembler : MonoBehaviour
{
    [SerializeField] private CoinManager coinManager;
    
    // Start is called before the first frame update
    void Start()
    {
        AssambleCoins();
    }

    private async Task AssambleCoins()
    {
        while (true)
        {
            await Task.Delay(coinManager.CoinData.SecondsAmountToAutoAssemblerIncreaseNumberOfCoins * 1000);

            coinManager.ChangeNumberOfCoinsByAutoAssembler();
        }
    }
}
