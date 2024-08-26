using UnityEngine;

public class LiftingNumber : MonoBehaviour
{
    public void OnEndLifting()
    {
        gameObject.SetActive(false);
    }
}
