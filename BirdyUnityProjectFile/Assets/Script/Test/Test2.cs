using UnityEngine;
using UnityEngine.UI;

public class Test2 : MonoBehaviour
{
    public GameObject item;
    public GameObject item2;
    public GameObject item3;
    public GameObject item4; // 아이템 오브제의 GameObject
    public Camera mainCamera; // 메인 카메라
    public Camera alternateCamera; // 선택지를 고를 때 사용될 대체 카메라
    public Button myButton; // 버튼을 참조할 변수
    public Button myButton1; // 버튼을 참조할 변수
    private bool isAlternateCameraActive = false; // 대체 카메라 활성화 여부를 저장하는 변수
    public string otherTag = "Block";

    private void Start()
    {
        // 버튼 비활성화
        myButton.gameObject.SetActive(false);
        // 버튼 비활성화
        myButton1.gameObject.SetActive(false);
    }
    // 다른 카메라로 시점 이동하는 함수
    public void SwitchToOtherCamera()
    {
        mainCamera.enabled = false; // 메인 카메라 비활성화
        alternateCamera.enabled = true; // 다른 카메라 활성화
    }

    // 버튼을 선택했을 때 호출되는 함수
    public void OnButtonClick()
    {
        Debug.Log("버튼을 선택했습니다. 메인 카메라로 복구합니다.");
        // 대체 카메라가 활성화된 경우 비활성화
        if (isAlternateCameraActive)
        {
            alternateCamera.gameObject.SetActive(false);
            isAlternateCameraActive = false;
            mainCamera.gameObject.SetActive(true);

            // 버튼 비활성화
            myButton.gameObject.SetActive(false);
            myButton1.gameObject.SetActive(false);

            // 아이템 오브젝트를 플레이어의 자식 오브젝트로 설정하고 비활성화
            item.transform.SetParent(transform);
            item.GetComponent<Renderer>().enabled = false;
            item2.transform.SetParent(transform);
            item2.GetComponent<Renderer>().enabled = false;
            item3.transform.SetParent(transform);
            item3.GetComponent<Renderer>().enabled = false;
            item4.transform.SetParent(transform);
            item4.GetComponent<Renderer>().enabled = false;
            GameObject[] otherObjects = GameObject.FindGameObjectsWithTag(otherTag);
            foreach (GameObject obj in otherObjects)
            {
                Destroy(obj);
            }
        }
    }
    public void OnButtonClick1()
    {
        Debug.Log("버튼을 선택했습니다. 메인 카메라로 복구합니다.");
        // 대체 카메라가 활성화된 경우 비활성화
        if (isAlternateCameraActive)
        {
            alternateCamera.gameObject.SetActive(false);
            isAlternateCameraActive = false;
            mainCamera.gameObject.SetActive(true);

            // 버튼 비활성화
            myButton.gameObject.SetActive(false);
            myButton1.gameObject.SetActive(false);

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Item"))
        {
            Debug.Log("아이템 오브제와 충돌하였습니다. 카메라를 전환합니다.");

            // 대체 카메라가 비활성화된 경우 활성화
            if (!isAlternateCameraActive)
            {
                alternateCamera.gameObject.SetActive(true);
                isAlternateCameraActive = true;
                mainCamera.gameObject.SetActive(false);
                // 버튼 활성화
                myButton.gameObject.SetActive(true);
                myButton1.gameObject.SetActive(true);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Item"))
        {
            Debug.Log("아이템 오브제와 충돌을 벗어났습니다.");
            // 버튼 선택 여부에 따라 카메라 복구
            if (!isAlternateCameraActive)
            {
                mainCamera.gameObject.SetActive(true);
            }
        }
        item.GetComponent<Renderer>().enabled = true;
    }
}