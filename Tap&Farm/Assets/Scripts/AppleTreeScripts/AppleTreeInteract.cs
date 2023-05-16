using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTreeInteract : MonoBehaviour
{
    // Start is called before the first frame update
 public GameObject ui;
 public AppleTreeStateCheck appletreestate;
 public GameObject InventoryButton;


    // Update is called once per frame
    void Update()
    {
        if (appletreestate.State == false){
            Timerout();
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.name == "Farmer")
        {
            ui.gameObject.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other){
         if (other.name == "Farmer")
        {
            ui.gameObject.SetActive(false);
        }
    }
    public void Collect(){
         // -----timer--------
        ui.gameObject.transform.GetChild(0).gameObject.SetActive(false);
        ui.gameObject.transform.GetChild(1).gameObject.SetActive(true);
        this.transform.GetChild(1).gameObject.SetActive(true);
        this.transform.GetChild(0).gameObject.SetActive(false);
        appletreestate.State = false;
        appletreestate.stopwatchwatchCall = false;
        InventoryButton.GetComponent<Inventory>().inventory["Apples"] += Random.Range(5,10);
       
    }
    void Timerout(){
        if (appletreestate.timer.seconds==0){
            ui.gameObject.transform.GetChild(1).gameObject.SetActive(false);
            ui.gameObject.transform.GetChild(0).gameObject.SetActive(true);
            this.transform.GetChild(0).gameObject.SetActive(true);
            this.transform.GetChild(1).gameObject.SetActive(false);
            appletreestate.State=true; 
        }
    }
}


