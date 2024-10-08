using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OVR;

public class OVRFadeinout : MonoBehaviour
{
    //공용변수 GameObject속성의 CenterEyeObj 지정
    public GameObject CenterEyeObj;
    //OVRScreenFade 를 OFade로 지정
    OVRScreenFade OFade;
    void Start()
    {
        //OFade는 CenterEyeObj의 변형에 OVRScreenFade 스크립트를 컴포넌트로 가져온다
        OFade = CenterEyeObj.transform.GetComponent<OVRScreenFade>();
    }

    void Update()
    {
        //만약 마우스를 클릭하면
        if (Input.GetMouseButtonDown(0))
        {
            //OFade 를 페이드 아웃 시켜라
            OFade.FadeOut();
        }
        //만약 마우스를 클릭하면
        if (Input.GetMouseButtonDown(1))
        {
            //OFade 를 페이드 인 시켜라
            OFade.FadeIn();
        }
    }
}