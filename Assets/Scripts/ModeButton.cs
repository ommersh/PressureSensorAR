using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeButton : MonoBehaviour
{
    // Array to hold references to all the associated text objects
    public GameObject[] associatedObjects;

    // Track the index of the currently visible object
    private int currentObjectIndex = 0;

    public void Start()
    {
        // Hide all associated objects initially
        foreach (GameObject obj in associatedObjects)
        {
            obj.SetActive(false);
        }
        // Show the first associated object initially
        associatedObjects[currentObjectIndex].SetActive(true);
    }

    public void ToggleVisibility()
    {
        // Hide the currently visible object
        associatedObjects[currentObjectIndex].SetActive(false);

        // Increment the index to show the next object
        currentObjectIndex = (currentObjectIndex + 1) % associatedObjects.Length;

        // Show the next associated object
        associatedObjects[currentObjectIndex].SetActive(true);
    }
}
