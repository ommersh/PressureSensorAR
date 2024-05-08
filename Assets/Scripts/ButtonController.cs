using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public GameObject associatedText; // Reference to the associated text object

    private bool isTextVisible = false; // Track the visibility state of the text

    void Start()
    {
        // Hide the associated text object initially
        associatedText.SetActive(false);
    }

    public void ToggleVisibility()
    {
        // Check if the associated text object is currently active
        bool isActive = associatedText.activeSelf;

        // If the associated text object is already visible and we're trying to hide it, return
        if (isTextVisible && !isActive)
        {
            return;
        }

        // Toggle the visibility of the associated text object
        associatedText.SetActive(!isActive);
        isTextVisible = !isActive;
    }
}