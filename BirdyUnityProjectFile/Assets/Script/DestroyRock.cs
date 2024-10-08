using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyRock : MonoBehaviour
{
    public GameObject DisableRock;
    public GameObject TeleportPrefab2;
    public GameObject CorrectSound;
    
    //�� ��ũ��Ʈ�� ��̷� ������ ���ӿ�����Ʈ�� ���ԵǾ��ִ� ���ӿ�����Ʈ�� ������ �ݶ��̵� �� ������ ��Ȱ��ȭ �Ǵ� ��ũ��Ʈ�Դϴ�.
    //��̿��� ��ũ��Ʈ�� �ݴϴ�.
    //�� Rigidbody(Gravity.Disabled)�� �� ������Ʈ�� �־�� �մϴ�. ////////
    void OnTriggerEnter(Collider col)
        //���ӿ�����Ʈ(triggeron)�� �ݶ��̴� col�� �浹 ��
    {
        //���� �ݶ��̴� col�� "block" �±׸� �����Ѵٸ�
        if (col.gameObject.CompareTag("Block"))
        {
            //DIsableRock ���ӿ�����Ʈ�� ���ش�.
            DisableRock.SetActive(false);
            Instantiate(TeleportPrefab2);
            Instantiate(CorrectSound);
        }
        
    }
}
