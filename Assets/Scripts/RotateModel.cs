using UnityEngine;
using UnityEngine.InputSystem;

public class ObjectRotation : MonoBehaviour
{
    public float rotationSpeed = 3f; // Speed of object rotation

    public GameObject objectToRotate; // Reference to the GameObject to be rotated

    private Vector2 mouseDelta; // Store mouse movement delta

    void Update()
    {
        // Rotate the object based on mouse movement
        if (Mouse.current.rightButton.isPressed && objectToRotate != null) // For right mouse button
        {
            // Get the mouse movement delta
            mouseDelta = Mouse.current.delta.ReadValue();

            // Calculate rotation amount based on mouse movement
            float rotationAmountX = mouseDelta.x * rotationSpeed * Time.deltaTime;
            float rotationAmountY = mouseDelta.y * rotationSpeed * Time.deltaTime;

            // Rotate the object around its local up axis (horizontal movement)
            objectToRotate.transform.Rotate(objectToRotate.transform.up, -rotationAmountX, Space.Self);

            // Rotate the object around its local right axis (vertical movement)
            objectToRotate.transform.Rotate(objectToRotate.transform.right, rotationAmountY, Space.Self);
        }
    }
}
