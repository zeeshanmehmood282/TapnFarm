using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTreeStateCheck : MonoBehaviour
{
    public bool State = true;
    public bool stopwatchwatchCall =false;
    
    public Timer timer;
    public int seconds;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (State == false && stopwatchwatchCall == false){
            timer.StartStopwatch(seconds);
            stopwatchwatchCall = true;
        }
        
    }
}
