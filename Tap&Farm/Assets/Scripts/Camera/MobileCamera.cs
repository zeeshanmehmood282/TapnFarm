using UnityEngine;

public class MobileCamera : MonoBehaviour {

   public float dragSpeed = 50f;

   [SerializeField] float cameraHeight = 15.57f;

    private Vector3 dragOrigin;

    [SerializeField] float scrollspeed = 1f;

    [SerializeField]
    private LayerMask draggableLayer;

    void Update()
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

        // clamp camera position to prevent movement on the y-axis

        if(Input.mouseScrollDelta.y != 0)
        {
            float scrollDelta = Input.mouseScrollDelta.y;
            cameraHeight += scrollDelta * scrollspeed;
        }

        Vector3 clampedPos = transform.position;
        clampedPos.y = cameraHeight;
        transform.position = clampedPos;

        dragOrigin = Input.mousePosition;
    }
    }
