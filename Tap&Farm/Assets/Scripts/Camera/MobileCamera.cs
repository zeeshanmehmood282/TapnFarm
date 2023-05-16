using UnityEngine;

public class MobileCamera : MonoBehaviour
{
    public float dragSpeed = 50f;
    public float cameraHeight = 15.57f;
    public float scrollSpeed = 1f;
    public Transform limitObject;
    public float maxDistanceFromLimit = 10f;

    private Vector3 dragOrigin;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            dragOrigin = Input.mousePosition;
            return;
        }

        if (!Input.GetMouseButton(0)) return;

        Vector3 pos = Camera.main.ScreenToViewportPoint(dragOrigin - Input.mousePosition);
        Vector3 move = new Vector3(pos.x * dragSpeed, 0, pos.y * dragSpeed);

        transform.Translate(move, Space.Self);

        // Limit camera movement within a specific distance from the limitObject
        if (limitObject != null)
        {
            Vector3 clampedPos = transform.position;
            float distance = Vector3.Distance(limitObject.position, clampedPos);
            float maxDistance = maxDistanceFromLimit;

            if (distance > maxDistance)
            {
                Vector3 direction = (clampedPos - limitObject.position).normalized;
                clampedPos = limitObject.position + direction * maxDistance;
            }

            transform.position = new Vector3(clampedPos.x, cameraHeight, clampedPos.z);
        }

        if (Input.mouseScrollDelta.y != 0)
        {
            float scrollDelta = Input.mouseScrollDelta.y;
            cameraHeight += scrollDelta * scrollSpeed;
        }

        dragOrigin = Input.mousePosition;
    }
}
