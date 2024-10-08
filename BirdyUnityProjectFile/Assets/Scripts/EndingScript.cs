using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingScript : MonoBehaviour
{
    public GameObject itemObject;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("item") && collision.gameObject.transform.IsChildOf(itemObject.transform))
        {
            Debug.Log("Item " + collision.gameObject.name + " collided with " + itemObject.name);
        }
    }
}
