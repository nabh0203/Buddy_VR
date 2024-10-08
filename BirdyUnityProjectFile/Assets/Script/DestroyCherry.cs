using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCherry : MonoBehaviour
{
    public GameObject DisableCherry;
    public GameObject TeleportPrefab2;
    public GameObject CherrySound;
    //�� ��ũ��Ʈ�� �÷��̾�� ������ ���ӿ�����Ʈ�� ���ԵǾ��ִ� ���ӿ�����Ʈ�� ü���� �ݶ��̵� �� ü���� ��Ȱ��ȭ �Ǵ� ��ũ��Ʈ�Դϴ�.
    //�÷��̾�� ��ũ��Ʈ�� �ݴϴ�.
    //�� Rigidbody(Gravity.Disabled)�� �� ������Ʈ�� �־�� �մϴ�. ////////
    void OnTriggerEnter(Collider col)
    //���ӿ�����Ʈ(triggeron)�� �ݶ��̴� col�� �浹 ��
    {
        //���� �ݶ��̴� col�� "block" �±׸� �����Ѵٸ�
        if (col.gameObject.CompareTag("Block2"))
        {
            //DIsableRock ���ӿ�����Ʈ�� ���ش�.
            DisableCherry.SetActive(false);
            Instantiate(TeleportPrefab2);
            Instantiate(CherrySound);
           
        }
    }
}
