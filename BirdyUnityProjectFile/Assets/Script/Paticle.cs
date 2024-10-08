using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paticle : MonoBehaviour
{
    public GameObject paticle;
    // Start is called before the first frame update
    void Start()
    {
        paticle.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            paticle.gameObject.SetActive(true);
        }
    }
}
