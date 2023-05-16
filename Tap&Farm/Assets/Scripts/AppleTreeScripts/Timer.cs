
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
     public TextMeshProUGUI Text;
    public int seconds;
    private bool isRunning;

    public void StartStopwatch(int startTime)
    {
        isRunning = true;
        seconds = startTime;
        InvokeRepeating("UpdateStopwatch", 0f, 1f);
    }

    public void StopStopwatch()
    {
        isRunning = false;
        CancelInvoke("UpdateStopwatch");
    }

    private void UpdateStopwatch()
    {
        seconds--;
        if (seconds < 0)
        {
            StopStopwatch();
            return;
        }

        int hours = seconds / 3600;
        int minutes = (seconds % 3600) / 60;
        int secondsToShow = seconds % 60;
        string timeString = hours.ToString("00") + ":" + minutes.ToString("00") + ":" + secondsToShow.ToString("00");
        Text.text = timeString;
    }
    
}
