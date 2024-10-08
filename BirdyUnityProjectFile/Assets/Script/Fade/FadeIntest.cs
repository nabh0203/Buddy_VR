using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIntest : MonoBehaviour
{
    //Image를 TestImage로 선언
    Image TestImage;
    //Color는 tmpColor로 선언
    Color tmpColor;
    void Start()
    {
        //tmpColor 는 Color.black 이다.
        tmpColor = Color.black;
        //tmpColor의 알파값은 1f = 255값
        tmpColor.a = 1f;
        //TestImage에 Image를 컴포넌트 해라
        TestImage = GetComponent<Image>();
        //TestImage 의 컬러는 tmpColor 와 같다.
        TestImage.color = tmpColor;
    }
    void Update()
    {
        // 만약 마우스를 클릭하면
        if (Input.GetMouseButtonDown(0))
        {
            //tmpColor의 알파값은  -0.01f씩 감소해라 
            tmpColor.a -= 0.01f;
            //TestImage의 컬러는 tmpColor 와 같다.
            TestImage.color = tmpColor;
        }
    }
}