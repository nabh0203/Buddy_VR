using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ObjectSelector : MonoBehaviour
{
    public GameObject objectToSelect; // 선택할 오브젝트
    public GameObject button; // 나타날 버튼
    public Camera mainCamera; // 메인 카메라
    public Camera otherCamera;
    public Transform startingPosition; // 처음 위치
    public float fadeOutDuration = 2.0f; // Fade Out에 걸리는 시간
    private bool isItemSelected = false; // 아이템이 선택되었는지 여부
    void Start()
    {
        // 메인 카메라를 찾아 활성화
        Camera.main.enabled = true;
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
            // 카메라 전환
            mainCamera.transform.position = objectToSelect.transform.position;
            mainCamera.transform.LookAt(objectToSelect.transform);
            mainCamera.fieldOfView = 60.0f;

            // 버튼 활성화
            button.SetActive(true);
        }
    }

    public void SelectObject()
    {
        // 아이템 선택 완료 처리
        Debug.Log("아이템 선택 완료");
        isItemSelected = true;

        // Fade Out 및 처음 위치로 이동
        StartCoroutine(FadeOutAndMoveToStartingPosition());
    }

    IEnumerator FadeOutAndMoveToStartingPosition()
    {
        // Fade Out 애니메이션 처리
        Image buttonImage = button.GetComponent<Image>();
        Color originalColor = buttonImage.color;
        float elapsedTime = 0.0f;
        while (elapsedTime < fadeOutDuration)
        {
            float alpha = Mathf.Lerp(1.0f, 0.0f, elapsedTime / fadeOutDuration);
            buttonImage.color = new Color(originalColor.r, originalColor.g, originalColor.b, alpha);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // 처음 위치로 이동
        mainCamera.transform.position = startingPosition.position;
        mainCamera.transform.rotation = startingPosition.rotation;
        mainCamera.fieldOfView = 60.0f;

        // 버튼 비활성화 및 아이템 선택 상태 초기화
        button.SetActive(false);
        isItemSelected = false;
    }
}
