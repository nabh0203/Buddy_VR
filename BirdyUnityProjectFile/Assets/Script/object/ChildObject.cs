using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildObject : MonoBehaviour
{
    private void Start()
    {
        // Get the parent object
        GameObject parentObject = gameObject.transform.parent.gameObject;

        // Check if the parent object has one of the inheritable tags
        if (parentObject.CompareTag("Window") ||
            parentObject.CompareTag("Cat") ||
            parentObject.CompareTag("Apple") ||
            parentObject.CompareTag("Bread"))
        {
            // Inherit the tag
            gameObject.tag = parentObject.tag;
        }
    }
}
