using UnityEngine;

public class CoinComponent : MonoBehaviour
{
    public int maxcoin = 10;
    public float currentcoin;

    public delegate void OnCoinChangedHandler(float newcoin, float amountChanged);
    //public event OnCoinChangedHandler OnCoinChanged;

    public delegate void OnCoinInitilizedHandler(float newcoin);
    //public event OnCoinInitilizedHandler OnCoinInitialized;

    public delegate void CoinEventHandler(float ncurrentPoints, float amountChanged);
    public event CoinEventHandler CoinAmountChanged;

    public float points;

    private void Start()
    {
        AddPoints(0);
    }

    public void AddPoints(float amount)
    {
        points += amount;
        CoinAmountChanged?.Invoke(points, amount);
    }

}