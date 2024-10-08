using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tagplus : MonoBehaviour
{
    public string tagName;
    public GameObject item;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        item.gameObject.tag = tagName;
    }
}
