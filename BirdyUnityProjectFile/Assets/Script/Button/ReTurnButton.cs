using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReTurnButton : MonoBehaviour
{
    public float fadeOutDuration = 0.5f;
    public float moveBackDuration = 0.5f;
    public Vector3 originalPosition;

    private Image image;
    private Button button;

    private void Start()
    {
        image = GetComponent<Image>();
        button = GetComponent<Button>();

        // 버튼에 클릭 이벤트 리스너 추가
        if (button != null)
        {
            button.onClick.AddListener(OnButtonClick);
        }
    }

    private void OnButtonClick()
    {
        // 버튼 클릭 시 페이드 아웃 및 원래 위치로 이동하는 코루틴 실행
        StartCoroutine(FadeOutAndMoveBackCoroutine());
    }

    public IEnumerator FadeOutAndMoveBackCoroutine()
    {
        // 페이드 아웃
        float elapsedTime = 0;
        while (elapsedTime < fadeOutDuration)
        {
            float alpha = Mathf.Lerp(1f, 0f, elapsedTime / fadeOutDuration);
            image.color = new Color(image.color.r, image.color.g, image.color.b, alpha);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // 원래 위치로 이동
        Vector3 startPos = transform.position;
        Vector3 endPos = originalPosition;
        elapsedTime = 0;
        while (elapsedTime < moveBackDuration)
        {
            transform.position = Vector3.Lerp(startPos, endPos, elapsedTime / moveBackDuration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // 초기 상태로 리셋
        transform.position = originalPosition;
        image.color = new Color(image.color.r, image.color.g, image.color.b, 1f);
    }
}


