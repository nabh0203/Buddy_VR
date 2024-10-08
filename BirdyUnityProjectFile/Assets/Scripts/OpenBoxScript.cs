using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBoxScript : MonoBehaviour
{
    public GameObject VRBox;
    public GameObject Rock;
    public GameObject Rock1;
    public GameObject UnRock;
    public GameObject UnRock1;
    public GameObject Key;
    public GameObject Box;
    public GameObject Sound;
    public GameObject InCorrectSound;
    public GameObject NextTeleport;
    public GameObject Key1;
    public GameObject Key2;
    public GameObject Key3;
    public GameObject Key4;
    public GameObject KeyEffect1;
    public GameObject KeyEffect2;
    public GameObject KeyEffect3;
    public GameObject KeyEffect4;
    public GameObject KeyAreaEffect1;

    private void Start()
    {
        VRBox.gameObject.SetActive(false);
        UnRock.gameObject.SetActive(false);
        UnRock1.gameObject.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        // Player 태그를 가진 오브젝트가 트리거 되면 
        if (other.CompareTag("Key"))
        {
            Box.gameObject.AddComponent<BoxCollider>();

            // 추가된 콜라이더 설정
            /*BoxCollider boxCollider = Box.gameObject.GetComponent<BoxCollider>();
            boxCollider.isTrigger = true;
            boxCollider.size = new Vector3(2, 2, 2);*/
            Rock.gameObject.SetActive(false);
            Rock1.gameObject.SetActive(false);
            VRBox.gameObject.SetActive(true);
            UnRock.gameObject.SetActive(true);
            UnRock1.gameObject.SetActive(true);
            Key.gameObject.SetActive(false);
            NextTeleport.gameObject.SetActive(true);
            Box.gameObject.SetActive(false);
            Instantiate(Sound);
            Key1.gameObject.SetActive(false);
            Key2.gameObject.SetActive(false);
            Key3.gameObject.SetActive(false);
            Key4.gameObject.SetActive(false);
            KeyEffect1.gameObject.SetActive(false);
            KeyEffect2.gameObject.SetActive(false);
            KeyEffect3.gameObject.SetActive(false);
            KeyEffect4.gameObject.SetActive(false);
            KeyAreaEffect1.gameObject.SetActive(false);


        }
        else if (other.CompareTag("WrongKey"))
            {
                Instantiate(InCorrectSound);
            }
    }
}
