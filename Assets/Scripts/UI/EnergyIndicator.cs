using UnityEngine;
using UnityEngine.UI;

public class EnergyIndicator : MonoBehaviour
{
    [SerializeField] private Image energyIndicatorImage;
    [SerializeField] private EnergyManager energyManager;

    private void Start()
    {
        SetEnergyIndicator();

        energyManager.NumberOfEnergyIsChanged += SetEnergyIndicator;
    }

    private void SetEnergyIndicator()
    {
        energyIndicatorImage.fillAmount = energyManager.CurrentAmountOfEnergy / energyManager.MaxAmountOfEnergy;
    }
}
