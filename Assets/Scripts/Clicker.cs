using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class Clicker : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] CoinManager coinManager;

    public void OnPointerDown(PointerEventData eventData)
    {
        coinManager.ChangeNumberOfCoinsByClick();
    }
}
