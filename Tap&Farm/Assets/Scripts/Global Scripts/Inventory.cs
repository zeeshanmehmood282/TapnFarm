using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Inventory : MonoBehaviour
{

    public Dictionary<string, int> inventory = new Dictionary<string, int>();



    void Start(){
        inventory.Add("Shaljam",0);
        inventory.Add("Apples",0);
    }
   public void ShowInventory()
    {
        int count = 1;
        // Iterate over the dictionary and print its elements
        foreach (KeyValuePair<string, int> kvp in inventory)
        {
            string key = kvp.Key;
            int value = kvp.Value;
            this.gameObject.transform.GetChild(count).gameObject.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = value.ToString();
            count+=1;

        }
    }
}
