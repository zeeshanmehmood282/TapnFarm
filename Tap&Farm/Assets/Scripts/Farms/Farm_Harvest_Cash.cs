using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Farm_Harvest_Cash : MonoBehaviour
{
    // Start is called before the first frame update
    public int coinsToAdd = 20; // Change this value to set the number of coins to add
    private Currency_Manager coin_manager;


    void OnMouseDown() {
        coin_manager = FindObjectOfType<Currency_Manager>();
        coin_manager.AddCoins(coinsToAdd); // Add coins to CoinManager
        this.gameObject.SetActive(false); // Deactivate the clicked game object
    }
}
