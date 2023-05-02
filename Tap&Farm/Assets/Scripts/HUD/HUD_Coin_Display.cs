using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HUD_Coin_Display : MonoBehaviour
{

    public TextMeshProUGUI coinText;
    
    public int currentCoins;

    public GameObject coin_manager;
    private Currency_Manager _currency;
    
    void Start()
    {
        _currency = coin_manager.GetComponent<Currency_Manager>();
        currentCoins = _currency.Coins;
        UpdateCoinText();
    }
    
    

    
    public void UpdateCoinText()
    {
        currentCoins = _currency.Coins;
        coinText.text = "Coins: " + currentCoins;
    }
}
