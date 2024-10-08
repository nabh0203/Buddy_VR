using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIInterface : MonoBehaviour
{
    public GameObject UIPrefab;

    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("UICollider"))
        {

            Instantiate(UIPrefab);
            /*Debug.Log("UI");*/
        }



    }
}
