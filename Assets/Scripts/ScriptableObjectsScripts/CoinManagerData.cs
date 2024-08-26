using UnityEngine;

[CreateAssetMenu(fileName = "CoinManagerData", menuName = "GameData/CoinManagerData")]
public class CoinManagerData : ScriptableObject
{
    [SerializeField] private float stepIncreaseNumberOfCoinsByAutoAssembler;
    [SerializeField] private float percentageForIncreaseNumberOfCoins;
    [SerializeField] private int secondsAmountToAutoAssemblerIncreaseNumberOfCoins;

    public float StepIncreaseNumberOfCoinsByAutoAssembler => stepIncreaseNumberOfCoinsByAutoAssembler;
    public float PercentageForIncreaseNumberOfCoins => percentageForIncreaseNumberOfCoins;

    public float StepIncreaseNumberOfCoinsByClick => stepIncreaseNumberOfCoinsByAutoAssembler + ((stepIncreaseNumberOfCoinsByAutoAssembler / 100) * percentageForIncreaseNumberOfCoins);

    public int SecondsAmountToAutoAssemblerIncreaseNumberOfCoins => secondsAmountToAutoAssemblerIncreaseNumberOfCoins;
}
