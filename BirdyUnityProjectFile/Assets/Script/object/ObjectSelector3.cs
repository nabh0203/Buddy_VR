using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSelector3 : MonoBehaviour
{
    public GameObject objectToSelect; // 선택할 오브젝트
    public GameObject button; // 나타날 버튼
    public Camera mainCamera; // 메인 카메라
    public Transform startingPosition; // 처음 위치
    public GameObject player; // 플레이어 오브젝트

    private bool isItemSelected = false; // 아이템이 선택되었는지 여부
    private Vector3 originalObjectPosition; // 오브젝트의 원래 위치
    private Quaternion originalObjectRotation; // 오브젝트의 원래 회전값
    private Camera originalCamera; // 원래 사용하던 카메라

    void Start()
    {
        // 메인 카메라를 찾아 활성화
        Camera.main.enabled = true;

        // 오브젝트의 원래 위치와 회전값 저장
        originalObjectPosition = objectToSelect.transform.position;
        originalObjectRotation = objectToSelect.transform.rotation;

        // 버튼 비활성화
        button.SetActive(false);

        // 원래 사용하던 카메라 저장
        originalCamera = mainCamera;
    }

    void Awake()
    {
        // mainCamera 변수에 현재 Scene에서 "Main Camera" 태그를 가진 카메라를 찾아 할당
        mainCamera = Camera.main;
    }

    void Update()
    {
        // 선택할 오브젝트가 활성화되어 있고 스페이스바를 누를 경우
        if (objectToSelect.activeSelf && !isItemSelected && Input.GetKeyDown(KeyCode.Space))
        {
            // 오브젝트의 원래 위치와 회전값으로 복원
            objectToSelect.transform.position = originalObjectPosition;
            objectToSelect.transform.rotation = originalObjectRotation;

            // 원래 사용하던 카메라로 전환
            mainCamera.enabled = false;
            originalCamera.enabled = true;
            mainCamera = originalCamera;

            // 버튼 활성화
            button.SetActive(true);
        }
    }

    public void OnButtonClick()
    {
        if (!isItemSelected)
        {
            // 아이템이 선택되었으면 원래 위치와 회전값으로 이동
            objectToSelect.transform.position = originalObjectPosition;
            objectToSelect.transform.rotation = originalObjectRotation;

            // 카메라 위치와 시야각 초기화
            mainCamera.transform.position = startingPosition.position;
            mainCamera.transform.LookAt(objectToSelect.transform);
            mainCamera.fieldOfView = 60.0f;

            // 버튼 비활성화 및 아이템 선택 여부 초기화
            button.SetActive(false);
            isItemSelected = false;
        }
        else
        {
            // 아이템이 선택된 상태이면 선택된 아이템을 얻는 처리를 진행
            // 여기에 선택된 아이템을 얻는 코드를 추가하세요
            Debug.Log("아이템을 얻었습니다: " + objectToSelect.name);

            // 아이템을 얻은 후, 오브젝트를 비활성화하고, 아이템이 선택된 상태를 true로 설정
            objectToSelect.SetActive(false);
            isItemSelected = true;
        }
    }
}
