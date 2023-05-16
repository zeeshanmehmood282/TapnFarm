using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuCamera : MonoBehaviour
{
    public float swayAmount = 1f;
    public float swayDistance = 0.2f;
    public float swaySpeed = 1f;

    private Vector3 initialPosition;

    private void Start()
    {
        initialPosition = transform.position;
    }

    private void Update()
    {
        float horizontalSway = Mathf.Sin(Time.time * swaySpeed) * swayAmount;
        float verticalSway = Mathf.Cos(Time.time * swaySpeed * 0.5f) * swayAmount;

        Vector3 swayOffset = new Vector3(horizontalSway, verticalSway, 0f) * swayDistance;
        transform.position = initialPosition + swayOffset;
    }
}
