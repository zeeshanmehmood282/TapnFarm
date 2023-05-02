using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Farm_1 : MonoBehaviour
{
    public GameObject level0;
    public GameObject level1;
    public GameObject level2;
    public GameObject level3;
    
    public TextMeshProUGUI coins;
    void Start()
    {
        // activate Level 0 and deactivate all others
        level0.SetActive(true);
        level1.SetActive(false);
        level2.SetActive(false);
        level3.SetActive(false);
        
        coins = GetComponent<TextMeshProUGUI>();
        // start the level switch coroutine
        StartCoroutine(SwitchLevels());
    }
    
    IEnumerator SwitchLevels()
    {
        yield return new WaitForSeconds(5f); // wait for 5 seconds
        
        // deactivate Level 0 and activate Level 1
        level0.SetActive(false);
        level1.SetActive(true);
        
        yield return new WaitForSeconds(5f); // wait for 5 seconds
        
        // deactivate Level 1 and activate Level 2
        level1.SetActive(false);
        level2.SetActive(true);
        
        yield return new WaitForSeconds(5f); // wait for 5 seconds
        
        // deactivate Level 2 and activate Level 3
        level2.SetActive(false);
        level3.SetActive(true);

        Debug.Log("Ready to Harvest");
    }
}
