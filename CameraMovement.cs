using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] float panSpeed = 5f;
    [SerializeField] float edgeSizeInPixels = 20f;

    [Header("Bounds")]
    [SerializeField] SpriteRenderer background;

    Camera cam;
    float minX, maxX, minY, maxY;

    bool MouseIsAtLeftEdge => Input.mousePosition.x <= edgeSizeInPixels;
    bool MouseIsAtRightEdge => Input.mousePosition.x >= Screen.width - edgeSizeInPixels;
    bool MouseIsAtBottomEdge => Input.mousePosition.y <= edgeSizeInPixels;
    bool MouseIsAtTopEdge => Input.mousePosition.y >= Screen.height - edgeSizeInPixels;

    void Start()
    {
        cam = Camera.main;
        CalculateBounds();
    }

    void Update()
    {
        Vector3 direction = Vector3.zero;

        if (MouseIsAtLeftEdge) direction += Vector3.left;
        if (MouseIsAtRightEdge) direction += Vector3.right;
        if (MouseIsAtBottomEdge) direction += Vector3.down;
        if (MouseIsAtTopEdge) direction += Vector3.up;

        MoveCamera(direction);
    }

    void MoveCamera(Vector3 direction)
    {
        if (direction == Vector3.zero) return;

        Vector3 newPos = transform.position + direction.normalized * panSpeed * Time.deltaTime;

        newPos.x = Mathf.Clamp(newPos.x, minX, maxX);
        newPos.y = Mathf.Clamp(newPos.y, minY, maxY);

        transform.position = newPos;
    }

    void CalculateBounds()
    {
        if (!background)
        {
            Debug.LogError("Background não atribuído!");
            return;
        }

        Bounds bg = background.bounds;

        float camHeight = cam.orthographicSize;
        float camWidth = camHeight * cam.aspect;

        minX = bg.min.x + camWidth;
        maxX = bg.max.x - camWidth;
        minY = bg.min.y + camHeight;
        maxY = bg.max.y - camHeight;
    }
}
