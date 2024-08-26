using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberSpawner : MonoBehaviour
{
    [SerializeField] private CoinManager CoinManager;

    [SerializeField] private GameObject[] numbers;

    [SerializeField] private GameObject numberPreprivatefab;
    
    // Start is called before the first frame update
    void Start()
    {
        CoinManager.IncreaseCoinsNumberByClicker += ActivateNumder;
    }

    private void ActivateNumder()
    {
        for(int i = 0; i < numbers.Length; i++)
        {
            if (!numbers[i].activeSelf)
            {
                numbers[i].SetActive(true);
                return;
            }
            
            if(i == numbers.Length - 1 && !numbers[i].activeSelf)
            {
                Instantiate(numberPreprivatefab, transform);
            }
        }
    }
}
