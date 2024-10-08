using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Move: MonoBehaviour
{
    public Camera minCamera; // 1��Ī �������� ����� ī�޶� ����
    public float cameraSpeed = 5.0f; // ī�޶� �̵� �ӵ�
    public float cameraRotationSpeed = 2.0f; // ī�޶� ȸ�� �ӵ�

    // ...

    void Update()
    {
        // ī�޶� �̵�
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 moveDirection = new Vector3(horizontal, 0.0f, vertical) * cameraSpeed * Time.deltaTime;
        minCamera.transform.position += minCamera.transform.TransformDirection(moveDirection);

        // ī�޶� ȸ��
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
        Vector3 rotation = new Vector3(-mouseY, mouseX, 0.0f) * cameraRotationSpeed * Time.deltaTime;
        minCamera.transform.eulerAngles += rotation;
    }
}


