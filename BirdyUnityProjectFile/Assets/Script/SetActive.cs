using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActive : MonoBehaviour
{
    public GameObject Item;
    public GameObject Item2;
    // Start is called before the first frame update
    void Start()
    {
        // ����Ŭ����� ��Ÿ���� ������Ʈ
        Item.gameObject.SetActive(true);
        //���� �ڸ��� �ִ� ������Ʈ
        Item2.gameObject.SetActive(false); 
    }

    // Update is called once per frame
    //Ʈ���� �����ÿ�
    void OnTriggerEnter(Collider other)
    {
        // Player �±׸� ���� ������Ʈ�� Ʈ���� �Ǹ� 
        if (other.CompareTag("Player"))
        {
            // ����Ŭ����� �ִ� ������Ʈ ��Ȱ��ȭ
            Item.gameObject.SetActive(false);
            // ���� �ڸ��� �ִ� ������Ʈ Ȱ��ȭ
            Item2.gameObject.SetActive(true);
        }
    }
}
