using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 5f;

    private void Update()
    {
        // Move the object forward based on the moveSpeed
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }
}
