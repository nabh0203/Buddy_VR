using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIButtonChange : MonoBehaviour
{
    
    public GameObject UIButton;

    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("UIChangeButton"))
        {
            Debug.Log("whatthe");
            UIButton.SetActive(true);
            
        }



    }
}
