using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmState : MonoBehaviour
{
     public bool State = true;
    public bool stopwatchwatchCall =false;
    
    public Timer timer;
    public int seconds;

    private int TotalFarmStates;

    private int timeAfterStateChange;

    private int currentState = 0;

    private int timetochange;
    // Start is called before the first frame update
    void Start()
    {
        TotalFarmStates = this.gameObject.transform.childCount;
        timeAfterStateChange = seconds/(TotalFarmStates-1);
        timetochange=seconds-timeAfterStateChange;
        
    }

    // Update is called once per frame
    void Update()
    {
        print(TotalFarmStates);
        if (State == false && stopwatchwatchCall == false){
            timer.StartStopwatch(seconds);
            stopwatchwatchCall = true;
        }


        if (timetochange>=0 && timetochange == timer.seconds){

            stateUpdate();
        } 
        
    }

    void stateUpdate(){
        currentState ++;
        this.gameObject.transform.GetChild(currentState).gameObject.SetActive(true);
        this.gameObject.transform.GetChild(currentState-1).gameObject.SetActive(false);
        timetochange=timetochange-timeAfterStateChange;
    }
}
