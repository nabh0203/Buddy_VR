/*using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class UIManager : MonoBehaviour
{
    // 유형1 UI를 보관할 List.
    // 유형1 UI가 생성될 때마다 List에 추가됨
    public List<GameObject> Type1UIList;
    public GameObject[] uiList; // UI 배열
    // 유형2 UI를 보관할 변수.
    public GameObject Type2UI;
    private int currentUIIndex = 0; // 현재 UI의 인덱스
    // 유형1 UI가 생성되는 시간
    public float Type1UIDelay = 2f;

    // 유형1 UI가 화면에 유지되는 시간
    public float Type1UIDuration = 4f;

    void Start()
    {
        // 첫 번째, 세 번째 UI 생성 (유형1)
        CreateType1UI();
        CreateType1UI();

        // 두 번째, 네 번째, 다섯 번째 UI 생성 (유형2)
        CreateType2UI();
        CreateType2UI();
        CreateType2UI();
    }

    // 유형1 UI 생성 함수
    void CreateType1UI()
    {
        // 빈 오브젝트 생성
        GameObject newUI = new GameObject("Type1UI");

        // Image 컴포넌트 추가
        Image image = newUI.AddComponent<Image>();

        // 이미지 색상 설정
        image.color = Color.red;

        // Canvas 그룹 컴포넌트 추가 및 속성 설정
        CanvasGroup canvasGroup = newUI.AddComponent<CanvasGroup>();
        canvasGroup.alpha = 0f;                     // 처음에는 투명
        canvasGroup.interactable = false;           // 상호 작용 불가능하도록 설정
        canvasGroup.blocksRaycasts = false;         // 마우스 클릭을 무시하도록 설정

        // 생성된 UI 오브젝트를 List에 추가
        Type1UIList.Add(newUI);

        // 2초 후에 알파 값 설정
        Invoke("ActivateType1UI", Type1UIDelay);
    }

    // 유형1 UI 생성 후 2초 후에 알파 값을 설정하는 함수
    void ActivateType1UI()
    {
        foreach (GameObject ui in Type1UIList)
        {
            // CanvasGroup 컴포넌트 가져오기
            CanvasGroup canvasGroup = ui.GetComponent<CanvasGroup>();

            // 알파 값 설정
            canvasGroup.alpha = 1f;

            // 일정 시간 후에 비활성화하기
            Invoke("DeactivateType1UI", Type1UIDuration);
        }
    }

    // 유형1 UI 비활성화 함수
    void DeactivateType1UI()
    {
        foreach (GameObject ui in Type1UIList)
        {
            // CanvasGroup 컴포넌트 가져오기
            CanvasGroup canvasGroup = ui.GetComponent<CanvasGroup>();

            // 알파 값을 0으로 설정
            canvasGroup.alpha = 0f;

            // 상호작용 불가능하도록 설정
            canvasGroup.interactable = false;

            // 마우스 클릭 무시하도록 설정
            canvasGroup.blocksRaycasts = false;
        }
    }

    void CreateType2UI()
    {
        // 빈 오브젝트 생성
        GameObject newUI = new GameObject("Type2UI");

        // Image 컴포넌트 추가
        Image image = newUI.AddComponent<Image>();

        // 이미지 색상 설정
        image.color = Color.blue;

        // Canvas 그룹 컴포넌트 추가
        CanvasGroup canvasGroup = newUI.AddComponent<CanvasGroup>();

        // Button 컴포넌트 추가
        Button button = newUI.AddComponent<Button>();

        // 버튼이 눌렸을 때 호출할 함수 등록
        button.onClick.AddListener(DeactivateType2UI);

        // 생성된 UI를 비활성화
        canvasGroup.alpha = 0f;
        canvasGroup.interactable = false;
        canvasGroup.blocksRaycasts = false;

        // 생성된 UI를 변수에 설정
        Type2UI = newUI;

        // 2초 후에 UI 활성화
        Invoke("ActivateType2UI", Type1UIDelay);
    }

    // 유형2 UI 활성화 함수
    void ActivateType2UI()
    {
        // CanvasGroup 컴포넌트 가져오기
        CanvasGroup canvasGroup = Type2UI.GetComponent<CanvasGroup>();

        // 알파 값 설정
        canvasGroup.alpha = 1f;

        // 상호 작용 가능하도록 설정
        canvasGroup.interactable = true;

        // 마우스 클릭 처리 가능하도록 설정
        canvasGroup.blocksRaycasts = true;
    }

    // 유형2 UI 비활성화 함수
    void DeactivateType2UI()
    {
        // CanvasGroup 컴포넌트 가져오기
        CanvasGroup canvasGroup = Type2UI.GetComponent<CanvasGroup>();

        // 알파 값을 0으로 설정
        canvasGroup.alpha = 0f;

        // 상호작용 불가능하도록 설정
        canvasGroup.interactable = false;

        // 마우스 클릭 무시하도록 설정
        canvasGroup.blocksRaycasts = false;
    }
}
*/