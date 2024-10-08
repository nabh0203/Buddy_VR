using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIntest : MonoBehaviour
{
    //Image�� TestImage�� ����
    Image TestImage;
    //Color�� tmpColor�� ����
    Color tmpColor;
    void Start()
    {
        //tmpColor �� Color.black �̴�.
        tmpColor = Color.black;
        //tmpColor�� ���İ��� 1f = 255��
        tmpColor.a = 1f;
        //TestImage�� Image�� ������Ʈ �ض�
        TestImage = GetComponent<Image>();
        //TestImage �� �÷��� tmpColor �� ����.
        TestImage.color = tmpColor;
    }
    void Update()
    {
        // ���� ���콺�� Ŭ���ϸ�
        if (Input.GetMouseButtonDown(0))
        {
            //tmpColor�� ���İ���  -0.01f�� �����ض� 
            tmpColor.a -= 0.01f;
            //TestImage�� �÷��� tmpColor �� ����.
            TestImage.color = tmpColor;
        }
    }
}