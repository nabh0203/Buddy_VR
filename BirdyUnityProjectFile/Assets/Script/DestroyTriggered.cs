using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTriggered : MonoBehaviour
{
    
    public GameObject DestroyStuff;

    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("TeleportCollider"))
        {
            DestroyStuff.SetActive(false);

            /*Debug.Log("what!");*/
        }



    }
}
