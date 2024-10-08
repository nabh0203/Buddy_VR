using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeOuttest : MonoBehaviour
{
    //Image를 TestImage로 선언
    Image TestImage;
    //Color는 tmpColor로 선언
    Color tmpColor;  
    void Start()
    {
        //tmpColor 는 Color.black 이다.
        tmpColor = Color.black;
        //tmpColor 의 알파 값은 0f 다.
        tmpColor.a = 0f;
        //TestImage 에 Image를 컴포넌트
        TestImage = GetComponent<Image>();
        //TestImage 의 컬러는 tmpColor와 같다.
        TestImage.color = tmpColor;
    }
    void Update()
    {
        // 만약 마우스를 클릭하면
        if (Input.GetMouseButtonDown(0))
        {
            //tmpColor의 알파값을 0.1f 씩 증가
            tmpColor.a += 0.1f;
            //TestImage 의 컬러는 tmpColor와 같다.
            TestImage.color = tmpColor;
        }
    }
}