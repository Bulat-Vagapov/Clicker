using System;
using System.Threading.Tasks;
using UnityEngine;

public class EnergyManager : MonoBehaviour
{
    [SerializeField] private EnergyManagerData data;
    private float currentAmountOfEnergy;

    public float CurrentAmountOfEnergy => currentAmountOfEnergy;
    public float MaxAmountOfEnergy => data.MaxAmountOfEnergy;
    public bool EnoughtEnergy => currentAmountOfEnergy - data.AmountOfEnergyPerClick >= 0;

    public event Action NumberOfEnergyIsChanged;

    private void Awake()
    {
        currentAmountOfEnergy = data.MaxAmountOfEnergy;
        IncreaseNumberOfEnergy();
    }

    public void ReduseNumberOfEnergy()
    {
        currentAmountOfEnergy -= data.AmountOfEnergyPerClick;
        NumberOfEnergyIsChanged?.Invoke();
    }

    private async Task IncreaseNumberOfEnergy()
    {
        while(true)
        {
            if(currentAmountOfEnergy < MaxAmountOfEnergy)
            {
                currentAmountOfEnergy += data.StepIncreaseNumberOfEnergy;
                NumberOfEnergyIsChanged?.Invoke();
            }

            await Task.Delay((int)data.AmountOfSecondsToincreaseEnergy * 1000);
        }
    }
}
