using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalObjectSpawn : MonoBehaviour
{
    public GameObject ScarfPrefab;
    public GameObject ApplePrefab;
    public GameObject StickerPrefab;
    public GameObject DonutPrefab;

    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("SpawnFinals"))
        {
            ScarfPrefab.SetActive(true);
            ApplePrefab.SetActive(true);
            StickerPrefab.SetActive(true);
            DonutPrefab.SetActive(true);
        }



    }
}
