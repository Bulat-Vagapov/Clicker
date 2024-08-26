using UnityEngine;

[CreateAssetMenu(fileName = "EnergyManagerData", menuName = "GameData/EnergyManagerData")]
public class EnergyManagerData : ScriptableObject
{
    [SerializeField] private float maxAmountOfEnergy;
    [SerializeField] private float amountOfEnergyPerClick;
    [SerializeField] private float stepIncreaseNumberOfEnergy;
    [SerializeField] private float amountOfSecondsToincreaseEnergy;

    public float MaxAmountOfEnergy => maxAmountOfEnergy;
    public float AmountOfEnergyPerClick => amountOfEnergyPerClick;
    public float StepIncreaseNumberOfEnergy => stepIncreaseNumberOfEnergy;
    public float AmountOfSecondsToincreaseEnergy => amountOfSecondsToincreaseEnergy;
}
