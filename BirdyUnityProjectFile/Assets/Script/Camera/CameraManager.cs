using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Camera mainCamera; // ���� ī�޶�
    public Camera secondaryCamera; // �ٸ� ī�޶�

    void Start()
    {
        // ���� ���� �� ���� ī�޶� Ȱ��ȭ�ϰ�, �ٸ� ī�޶� ��Ȱ��ȭ
        mainCamera.enabled = true;
        secondaryCamera.enabled = false;
    }

    void Update()
    {
        // �����̽��ٸ� ���� ��� ī�޶� ��ȯ
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // ���� ī�޶�� �ٸ� ī�޶� ��ü
            mainCamera.enabled = !mainCamera.enabled;
            secondaryCamera.enabled = !secondaryCamera.enabled;
        }
    }
}
