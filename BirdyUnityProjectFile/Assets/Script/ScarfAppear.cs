using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScarfAppear : MonoBehaviour
{
    public GameObject ScarfUp; // �̵��� ������Ʈ
    public Vector3 destination; // �̵��� ��ġ
    public float moveSpeed; // �̵� �ӵ�
    private bool moveScarfUp; // ScarfUp �̵� ����
    /*private bool TActive; //���� ���� ����
    private bool EatCherry;
    public GameObject CherryEatable;
    public GameObject Tele1;
    public GameObject Tele2;
    public GameObject Tele3;
    public GameObject ChestUi;*/

    public void OnTriggerStay(Collider other)
    {
        //���� other�� ChestCollider �±׸� �����ϰ� �ִٸ�,
        if (other.CompareTag("ChestCollider"))
        {
            // �浹�� �����Ǹ� �̵� ����(moveScarfUp)�� true�� ����
            moveScarfUp = true;
        }
        /*//���� rugcollider��� �±׸� �����̽���
        if (other.CompareTag("RugCollider"))
        {
            //���� active�� true
            TActive = true;
        }*/
        /*if (other.CompareTag("CherryCollider"))
        {
            EatCherry = true;
        }*/
    }

    private void Update()
    {
        // �̵� ����(moveScarfUp)�� true�� ��쿡
        if (moveScarfUp)
        {
            // ScarfUp(�� ��ġ���� �ű��)�� (���ο� ��ġ��Vector3.������ ������ �����δ� =
            // (scarfup�� ��������, ������ ��ġ������, ���ǵ�))destination ��ġ�� ������(deltatime) �̵�
            ScarfUp.transform.position = Vector3.MoveTowards(ScarfUp.transform.position,
                destination, moveSpeed * Time.deltaTime);
            /*ChestUi.SetActive(true);
            Tele3.SetActive(true);*/
        }
        /*if(TActive)
        {
            Tele1.SetActive(true);
        }
        if (EatCherry)
        {
            CherryEatable.SetActive(false);
            Tele2.SetActive(true);
        }*/
    }

}
