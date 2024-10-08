using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OVR;

public class OVR_Fade : MonoBehaviour
{
    //���뺯�� GameObject�Ӽ��� CenterEyeObj ����
    public GameObject CenterEyeObj;
    //OVRScreenFade �� OFade�� ����
    OVRScreenFade OFade;
    void Start()
    {
        //OFade�� CenterEyeObj�� ������ OVRScreenFade ��ũ��Ʈ�� ������Ʈ�� �����´�
        OFade = CenterEyeObj.transform.GetComponent<OVRScreenFade>();
        OFade.FadeIn();
    }
}
