using System;
using TMPro;
using UnityEngine;

public class UI_MoneyDisplay : MonoBehaviour
{
    public CoinComponent Coin;
    public TextMeshProUGUI textComponent;

    private void Awake()
    {
        Coin.CoinAmountChanged += CoinComp_CoinAmountChanged;
    }

    private void CoinComp_CoinAmountChanged(float ncurrentPoints, float amountChanged)
    {
        textComponent.text = ncurrentPoints.ToString();
    }
}