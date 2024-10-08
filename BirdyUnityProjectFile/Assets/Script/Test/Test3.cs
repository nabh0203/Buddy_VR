using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test3 : MonoBehaviour
{
    public GameObject item; // 아이템 오브제의 GameObject
    public Camera mainCamera; // 메인 카메라
    public Camera alternateCamera; // 선택지를 고를 때 사용될 대체 카메라
    public Button myButton; // 버튼을 참조할 변수
    public Button myButton1; // 버튼을 참조할 변수
    private bool isAlternateCameraActive = false; // 대체 카메라 활성화 여부를 저장하는 변수
    // 상속받은 오브젝트의 초기 설정
    private void Awake()
    {
        transform.position = new Vector3(transform.position.x, -100f, transform.position.z);
    }

    // 상속받은 오브젝트의 시작 설정
    private void Start()
    {
        myButton.gameObject.SetActive(false);
        myButton1.gameObject.SetActive(false);
    }

    // 상속받은 오브젝트의 버튼 선택시 동작
    public void OnButtonClick()
    {
        Debug.Log("버튼을 선택했습니다. 메인 카메라로 복구합니다.");
        // 대체 카메라가 활성화된 경우 비활성화
        if (isAlternateCameraActive)
        {
            alternateCamera.gameObject.SetActive(false);
            isAlternateCameraActive = false;
            mainCamera.gameObject.SetActive(true);

            Renderer itemRenderer = item.GetComponent<Renderer>();
            if (itemRenderer != null)
            {
                item.transform.SetParent(transform);
                Color itemColor = itemRenderer.material.color;
                itemColor.a = 0f;
                itemRenderer.material.color = itemColor;
            }

            myButton.gameObject.SetActive(false);
            myButton1.gameObject.SetActive(false);
        }
    }

    // 충돌시 동작
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Item"))
        {
            Debug.Log("아이템 오브제와 충돌하였습니다. 카메라를 전환합니다.");

            if (!isAlternateCameraActive)
            {
                alternateCamera.gameObject.SetActive(true);
                isAlternateCameraActive = true;
                mainCamera.gameObject.SetActive(false);
                myButton.gameObject.SetActive(true);
                myButton1.gameObject.SetActive(true);
            }
        }
    }

    // 충돌 벗어났을 때 동작
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Item"))
        {
            Debug.Log("아이템 오브제와 충돌을 벗어났습니다.");
        }
    }
}

