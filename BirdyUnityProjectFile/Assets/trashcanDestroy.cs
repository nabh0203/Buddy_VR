using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trashcanDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("TrashT"))
        {
            this.gameObject.SetActive(false);
        }
    }
}
