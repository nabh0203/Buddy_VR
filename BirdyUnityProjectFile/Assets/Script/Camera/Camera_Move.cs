using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Move: MonoBehaviour
{
    public Camera minCamera; // 1인칭 시점에서 사용할 카메라 변수
    public float cameraSpeed = 5.0f; // 카메라 이동 속도
    public float cameraRotationSpeed = 2.0f; // 카메라 회전 속도

    // ...

    void Update()
    {
        // 카메라 이동
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 moveDirection = new Vector3(horizontal, 0.0f, vertical) * cameraSpeed * Time.deltaTime;
        minCamera.transform.position += minCamera.transform.TransformDirection(moveDirection);

        // 카메라 회전
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
        Vector3 rotation = new Vector3(-mouseY, mouseX, 0.0f) * cameraRotationSpeed * Time.deltaTime;
        minCamera.transform.eulerAngles += rotation;
    }
}


