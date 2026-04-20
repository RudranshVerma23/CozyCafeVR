using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float sensitivity = 2f;
    public float moveSpeed = 2f;
    float rotX = 0f;

    void Update()
    {
        // Mouse look
        rotX -= Input.GetAxis("Mouse Y") * sensitivity;
        float rotY = Input.GetAxis("Mouse X") * sensitivity;
        transform.eulerAngles = new Vector3(rotX,
            transform.eulerAngles.y + rotY, 0);

        // WASD movement — uses camera's own forward/right
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 move = transform.forward * v + transform.right * h;
        move.y = 0f; // prevent floating up/down while moving
        transform.parent.position += move * moveSpeed * Time.deltaTime;
    }
}