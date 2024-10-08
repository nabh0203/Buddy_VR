using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockFourDestroy : MonoBehaviour
{
    //�� ��ũ��Ʈ�� 4�� �΋H�� �� Ư�� ���ӿ�����Ʈ�� �����˴ϴ�.
    public GameObject rock; //�����Ǵ� ��
    public GameObject RockSound;//�΋H�� ������ ���� ����
    public GameObject ClearSound; //Ŭ���� �� ����
    private int triggerCount = 0; //Ʈ���� �� ī��Ʈ �Ǽ��� ���� = 0

    private void OnTriggerEnter(Collider other)
    {
        //���� �ݶ��̴� other�� block��� �±׸� �����ϰ� �ִ� ���̰� Ʈ���� �� ��,
        if (other.gameObject.CompareTag("Block"))
        {
            
            //Ʈ���ŵ� ī��Ʈ�� 1�� �����Ѵ�
            triggerCount++;
            //ī��Ʈ�� �α׷� ��������
            Debug.Log("Count:" + triggerCount);

            //���� 4��°�� ī��Ʈ�� �����ϸ�,
            if (triggerCount >= 4)
            {
                //������ ���ӿ�����Ʈ�� ��������.
                rock.SetActive(false);
                //���� Ŭ���� �� ���尡 �����ȴ�(����ȴ�)
                Instantiate(ClearSound);
                //�α�â�� ���.
                Debug.Log("Destroyed");
            }
            else //ī��Ʈ�� 4 �̻��� �ƴ� ��, Ʈ���� ���� �� �׻�
            {
                //���� ��ȣ�ۿ� ���尡 �鸰��.
                Instantiate(RockSound);
            }
        }
    }
}
