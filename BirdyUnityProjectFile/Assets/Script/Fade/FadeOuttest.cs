using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeOuttest : MonoBehaviour
{
    //Image�� TestImage�� ����
    Image TestImage;
    //Color�� tmpColor�� ����
    Color tmpColor;  
    void Start()
    {
        //tmpColor �� Color.black �̴�.
        tmpColor = Color.black;
        //tmpColor �� ���� ���� 0f ��.
        tmpColor.a = 0f;
        //TestImage �� Image�� ������Ʈ
        TestImage = GetComponent<Image>();
        //TestImage �� �÷��� tmpColor�� ����.
        TestImage.color = tmpColor;
    }
    void Update()
    {
        // ���� ���콺�� Ŭ���ϸ�
        if (Input.GetMouseButtonDown(0))
        {
            //tmpColor�� ���İ��� 0.1f �� ����
            tmpColor.a += 0.1f;
            //TestImage �� �÷��� tmpColor�� ����.
            TestImage.color = tmpColor;
        }
    }
}