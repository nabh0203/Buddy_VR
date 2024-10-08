using UnityEngine;

public class ObjectSelector4 : MonoBehaviour
{
    public string playerTag = "Player"; // 플레이어 태그
    public GameObject[] objectsToSelect; // 선택할 오브젝트들
    public Transform[] startingPositions; // 오브젝트들의 시작 위치들
    public Camera mainCamera; // 메인 카메라
    public GameObject[] buttons; // 버튼들을 저장할 배열

    private GameObject selectedObject; // 선택된 오브젝트
    private bool isItemSelected = true; // 아이템이 선택되었는지 여부
    private Vector3 originalObjectPosition; // 오브젝트의 원래 위치
    private Quaternion originalObjectRotation; // 오브젝트의 원래 회전값

    void Start()
    {
        // 메인 카메라를 찾아 활성화
        Camera.main.enabled = true;

        // 오브젝트들의 원래 위치와 회전값 저장
        for (int i = 0; i < objectsToSelect.Length; i++)
        {
            originalObjectPosition = objectsToSelect[i].transform.position;
            originalObjectRotation = objectsToSelect[i].transform.rotation;
        }

        // 버튼 비활성화
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].SetActive(false);
        }
    }

    void Awake()
    {
        // mainCamera 변수에 현재 Scene에서 "Main Camera" 태그를 가진 카메라를 찾아 할당
        mainCamera = Camera.main;
    }

    void Update()
    {
        // 선택된 오브젝트가 없는 경우
        if (!isItemSelected)
        {
            // 플레이어의 위치와 선택 가능한 오브젝트들의 위치 사이의 거리를 계산하여 가장 가까운 오브젝트를 선택
            float shortestDistance = Mathf.Infinity;
            GameObject nearestObject = null;

            foreach (GameObject obj in objectsToSelect)
            {
                float distanceToPlayer = Vector3.Distance(obj.transform.position,
                                                           GameObject.FindGameObjectWithTag(playerTag).transform.position);
                if (distanceToPlayer < shortestDistance)
                {
                    shortestDistance = distanceToPlayer;
                    nearestObject = obj;
                }
            }

            // 플레이어가 일정 거리 내에 있고 선택 가능한 오브젝트가 있는 경우
            if (nearestObject != null && shortestDistance <= 0.3f)
            {
                // 버튼 활성화
                for (int i = 0; i < buttons.Length; i++)
                {
                    buttons[i].SetActive(true);
                }

                // 선택 가능한 오브젝트를 selectedObject 변수에 저장
                selectedObject = nearestObject;
            }
            else
            {
                // 버튼 비활성화
                for (int i = 0; i < buttons.Length; i++)
                {
                    buttons[i].SetActive(false);
                }

                // selectedObject 변수 초기화
                selectedObject = null;
            }
        }
    }

        // 아이템 선택 취소 시 호출되는 함수
        public void CancelSelection()
    {
        if (selectedObject != null && isItemSelected)
        {
            // 선택된 오브젝트를 원래 위치와 회전값으로 되돌림
            selectedObject.transform.parent = null;
            selectedObject.transform.position = originalObjectPosition;
            selectedObject.transform.rotation = originalObjectRotation;

            // 아이템 선택 상태 초기화
            selectedObject = null;
            isItemSelected = false;

        }
    }
}
