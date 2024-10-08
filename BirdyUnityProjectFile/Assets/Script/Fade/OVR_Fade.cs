using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OVR;

public class OVR_Fade : MonoBehaviour
{
    //공용변수 GameObject속성의 CenterEyeObj 지정
    public GameObject CenterEyeObj;
    //OVRScreenFade 를 OFade로 지정
    OVRScreenFade OFade;
    void Start()
    {
        //OFade는 CenterEyeObj의 변형에 OVRScreenFade 스크립트를 컴포넌트로 가져온다
        OFade = CenterEyeObj.transform.GetComponent<OVRScreenFade>();
        OFade.FadeIn();
    }
}
