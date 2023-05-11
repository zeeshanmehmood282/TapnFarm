using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Interact_Farm : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject ui;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
}
