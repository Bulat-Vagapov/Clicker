using System;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    [SerializeField] private CoinManagerData data;
    [SerializeField] private EnergyManager energyManager;

    private float currentCoinsCount;

    public CoinManagerData CoinData => data;

    public event Action<float> NumberOfCoinsIsChanged;
    public event Action IncreaseCoinsNumberByClicker;

    private void ChangeNumberOfCoins(float increaseStep)
    {
        currentCoinsCount += increaseStep;
        NumberOfCoinsIsChanged?.Invoke(currentCoinsCount);
    }

    public void ChangeNumberOfCoinsByAutoAssembler()
    {
        ChangeNumberOfCoins(data.StepIncreaseNumberOfCoinsByAutoAssembler);
    }

    public void ChangeNumberOfCoinsByClick()
    {
        if (!energyManager.EnoughtEnergy) return;
        
        ChangeNumberOfCoins(data.StepIncreaseNumberOfCoinsByClick);
        energyManager.ReduseNumberOfEnergy();
        IncreaseCoinsNumberByClicker?.Invoke();
    }
}
