using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleFall : MonoBehaviour
{
    public GameObject apple;
    public GameObject stick;
    public GameObject CorrectSound;
    public GameObject AppleEffect;
    public GameObject AppleEffect2;

    Rigidbody rigidbody2;
    void Start()
    {
        AppleEffect2.SetActive(false);
        rigidbody2 = apple.GetComponent<Rigidbody>();
        

    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == stick && rigidbody2 != null)
        {
            
                
                rigidbody2.useGravity = true;
                Instantiate(CorrectSound);
                AppleEffect.SetActive(false);
                AppleEffect2.SetActive(true);



        }
    }
    
}
