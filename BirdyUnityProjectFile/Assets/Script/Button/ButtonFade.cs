using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonFade : MonoBehaviour
{
    // 버튼의 CanvasGroup 컴포넌트를 연결할 변수
    public CanvasGroup buttonCanvasGroup;
    // 페이드 인에 걸리는 시간
    public float fadeInDuration = 1.0f;

    // Start 함수에서 페이드 인 애니메이션을 실행
    void Start()
    {
        // 버튼의 CanvasGroup 컴포넌트의 Alpha 값을 0으로 설정
        buttonCanvasGroup.alpha = 0;
        // 페이드 인 애니메이션 실행
        StartCoroutine(FadeInButton());
    }

    // 페이드 인 애니메이션 코루틴 함수
    IEnumerator FadeInButton()
    {
        // 페이드 인에 사용할 시간 변수 초기화
        float elapsedTime = 0;

        // 시간이 페이드 인에 걸리는 시간보다 작을 동안 반복
        while (elapsedTime < fadeInDuration)
        {
            // 버튼의 CanvasGroup 컴포넌트의 Alpha 값을 시간에 따라 증가시켜 페이드 인 효과 생성
            buttonCanvasGroup.alpha = Mathf.Lerp(0, 1, elapsedTime / fadeInDuration);
            // 경과 시간 업데이트
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // 페이드 인이 완료되면 CanvasGroup 컴포넌트를 활성화하여 버튼이 인터랙티브하게 동작하도록 설정
        buttonCanvasGroup.alpha = 1;
        buttonCanvasGroup.interactable = true;
        buttonCanvasGroup.blocksRaycasts = true;
    }
}
