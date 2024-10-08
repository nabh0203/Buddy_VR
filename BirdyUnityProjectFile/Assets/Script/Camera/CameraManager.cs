using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Camera mainCamera; // 메인 카메라
    public Camera secondaryCamera; // 다른 카메라

    void Start()
    {
        // 게임 시작 시 메인 카메라를 활성화하고, 다른 카메라를 비활성화
        mainCamera.enabled = true;
        secondaryCamera.enabled = false;
    }

    void Update()
    {
        // 스페이스바를 누를 경우 카메라 전환
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // 메인 카메라와 다른 카메라를 교체
            mainCamera.enabled = !mainCamera.enabled;
            secondaryCamera.enabled = !secondaryCamera.enabled;
        }
    }
}
