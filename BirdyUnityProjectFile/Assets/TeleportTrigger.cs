using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class TeleportTrigger : MonoBehaviour
{
    public GameObject teleport2Prefab;
    
    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("TeleportCollider")) { 
            Instantiate(teleport2Prefab);

            /*Debug.Log("what!");*/
        }
        
        
        
    }
}
