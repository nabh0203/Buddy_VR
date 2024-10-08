using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OVR;

public class OVRFadeinout : MonoBehaviour
{
    //���뺯�� GameObject�Ӽ��� CenterEyeObj ����
    public GameObject CenterEyeObj;
    //OVRScreenFade �� OFade�� ����
    OVRScreenFade OFade;
    void Start()
    {
        //OFade�� CenterEyeObj�� ������ OVRScreenFade ��ũ��Ʈ�� ������Ʈ�� �����´�
        OFade = CenterEyeObj.transform.GetComponent<OVRScreenFade>();
    }

    void Update()
    {
        //���� ���콺�� Ŭ���ϸ�
        if (Input.GetMouseButtonDown(0))
        {
            //OFade �� ���̵� �ƿ� ���Ѷ�
            OFade.FadeOut();
        }
        //���� ���콺�� Ŭ���ϸ�
        if (Input.GetMouseButtonDown(1))
        {
            //OFade �� ���̵� �� ���Ѷ�
            OFade.FadeIn();
        }
    }
}