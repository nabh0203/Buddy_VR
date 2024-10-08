using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TeleportEvent : MonoBehaviour
{
    public GameObject rawImage2;
    public GameObject prefab;
    private void OnTriggerEnter(Collider other)
    {
        if  (other.CompareTag("TeleportTrigger"))
            {
            Debug.Log("Æ®¸®°Å");
            rawImage2.SetActive(true);
            Instantiate(prefab, new Vector3(0.8f, 0f, -14.35f), Quaternion.identity);
            Instantiate(prefab, new Vector3(0.1f, 0f, -11.04f), Quaternion.identity);
            Instantiate(prefab, new Vector3(-0.04f, 0f, -7.81f), Quaternion.identity);
            Instantiate(prefab, new Vector3(0.17f, 0f, -4.679f), Quaternion.identity);
            Instantiate(prefab, new Vector3(0.58f, 0f, -1.78f), Quaternion.identity);
            Instantiate(prefab, new Vector3(0.58f, 0f, 0.57f), Quaternion.identity);
            Instantiate(prefab, new Vector3(0.3f, 0f, 3.86f), Quaternion.identity);
            Instantiate(prefab, new Vector3(-0.17f, 0f, 6.92f), Quaternion.identity);
            Instantiate(prefab, new Vector3(-0.04f, 0f, 9.6f), Quaternion.identity);
            Instantiate(prefab, new Vector3(-0.053f, 0f, 13.149f), Quaternion.identity);
            Instantiate(prefab, new Vector3(0.77f, 0f, -17.04f), Quaternion.identity);
        }

    }
}