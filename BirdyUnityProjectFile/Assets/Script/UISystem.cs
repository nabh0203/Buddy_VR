using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISystem : MonoBehaviour
{
    public GameObject UI1;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            UI1.SetActive(true);
        }
    }
}
