using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Currency_Manager : MonoBehaviour
{
    public int Coins = 15;

    private HUD_Coin_Display HUD_Coins;
    
    void Start()
    {
        HUD_Coins = FindObjectOfType<HUD_Coin_Display>();
        UpdateCoin();
    }
    
    
    
    public void SpendCoins(int amount)
    {
        Debug.Log("Coins Spent");
        if (Coins >= amount)
        {
            Coins -= amount;
            UpdateCoin();
        }
        else
        {
            Debug.Log("Not enough coins!");
        }
    }

    public void AddCoins(int amount)
    {
        Debug.Log("Coins Added");
        Coins =+ amount;
        UpdateCoin();
    }
    
    private void UpdateCoin()
    {
        HUD_Coins.UpdateCoinText();
    }
}
