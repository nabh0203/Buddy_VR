using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BushEvent : MonoBehaviour
{
    public GameObject Leaf1;
    public GameObject Leaf2;
    public GameObject Leaf3;
    /*public GameObject Leaf4;*/
    public GameObject UIPrefab;
    public GameObject CorrectPrefab;
    public GameObject InCorrectPrefab;
    public GameObject BushEffect1;
    public GameObject BushEffect2;
    public GameObject BushEffect3;
    public GameObject Leaves;
    

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == Leaf1 || other.gameObject == Leaf2)
        {
            
            Instantiate(InCorrectPrefab);
            BushEffect1.SetActive(false);

        }
        if (other.gameObject == Leaf3)
        {

            Instantiate(InCorrectPrefab);
            BushEffect2.SetActive(false);
        }
        if (other.CompareTag("StickerExit"))
        {
            Instantiate(UIPrefab);
            Instantiate(CorrectPrefab);
            BushEffect1.SetActive(false);
            BushEffect2.SetActive(false);
            BushEffect3.SetActive(false);
            Leaves.SetActive(false);
            

        }
    }
}
