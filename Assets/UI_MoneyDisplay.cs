using TMPro;
using UnityEngine;

public class UI_MoneyDisplay : MonoBehaviour
{
    public CoinComponent Coin;
    public TextMeshProUGUI textComponent;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Coin = GetComponent<CoinComponent>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}