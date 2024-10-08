using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnControl : MonoBehaviour
{

    private Vector3 startingPosition;
    public GameObject RespawnSoundPrefab;

    void Start()
    {
        startingPosition = transform.position;
    }

    void OnTriggerEnter(Collider other)
    {
        // �浹�� ������Ʈ�� �÷��̾��� ���
        if (other.CompareTag("Trash"))
        {
            // �÷��̾ ������ ����Ʈ�� ��ġ �̵�
            gameObject.transform.position = startingPosition;
            Instantiate(RespawnSoundPrefab);

        }
    }


}



