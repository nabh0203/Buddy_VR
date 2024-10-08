using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBox : MonoBehaviour
{
    public GameObject Rock;
    public GameObject Rock2;
    public GameObject Key;
    public GameObject Box;

    private void Start()
    {
        Rock2.gameObject.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        // Player �±׸� ���� ������Ʈ�� Ʈ���� �Ǹ� 
        if (other.CompareTag("Key"))
        {
            Box.gameObject.AddComponent<BoxCollider>();

            // �߰��� �ݶ��̴� ����
            BoxCollider boxCollider = Box.gameObject.GetComponent<BoxCollider>();
            boxCollider.isTrigger = true;
            boxCollider.size = new Vector3(2, 2, 2);
            Rock.gameObject.SetActive(false);
            Rock2.gameObject.SetActive(true);
            Key.gameObject.SetActive(false);

        }
    }
}
