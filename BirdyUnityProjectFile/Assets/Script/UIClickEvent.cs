using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class UIClickEvent : MonoBehaviour
{
    public GameObject rawImage2;
    public Button myButton;

    void Start()
    {
        myButton.onClick.AddListener(OnButtonClick);
    }

    public void OnButtonClick()
    {
        Debug.Log("Button clicked!");
        myButton.gameObject.SetActive(false);
        rawImage2.SetActive(true);


    }
}
