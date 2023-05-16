using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Interact_Farm : MonoBehaviour
{
    // Start is called before the first frame update

   public GameObject ui;
 public FarmState farmState;
 public GameObject InventoryButton;


    // Update is called once per frame
    void Update()
    {
        if (farmState.State == false){
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
    public void Plant(){
         // -----timer--------
        ui.gameObject.transform.GetChild(0).gameObject.SetActive(false);
        ui.gameObject.transform.GetChild(1).gameObject.SetActive(true);
        this.gameObject.transform.GetChild(0).gameObject.SetActive(true);
        farmState.State = false;
        farmState.stopwatchwatchCall = false;
       
    }
    void Timerout(){
        if (farmState.timer.seconds==0){
            ui.gameObject.transform.GetChild(1).gameObject.SetActive(false);
            ui.gameObject.transform.GetChild(2).gameObject.SetActive(true);
            farmState.State=true; 
        }
    }

    public void Collect(){
        ui.gameObject.transform.GetChild(2).gameObject.SetActive(false);
        ui.gameObject.transform.GetChild(0).gameObject.SetActive(true);
        this.gameObject.transform.GetChild(this.gameObject.transform.childCount-1).gameObject.SetActive(false);
        InventoryButton.GetComponent<Inventory>().inventory["Shaljam"]+= Random.Range(5,10);

    }
}
