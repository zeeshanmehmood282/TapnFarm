using UnityEngine;

public class ObjectRotator : MonoBehaviour
{
    [SerializeField] private Vector3 axis = Vector3.up;
    [SerializeField] private float speed = 1f;

    private void Update()
    {
        transform.Rotate(axis, speed * Time.deltaTime);
    }
}