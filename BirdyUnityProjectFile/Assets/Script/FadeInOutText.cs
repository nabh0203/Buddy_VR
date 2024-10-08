using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class FadeInOutText : MonoBehaviour
{
    public float fadeDuration = 1.5f;  // 페이드 인/아웃 지속시간
    public float displayDuration = 2.0f;  // 텍스트가 화면에 표시되는 시간
    public Text text;  // 화면에 나타날 텍스트

    private IEnumerator Start()
    {
        // 초기에는 텍스트를 투명하게 만듭니다.
        Color originalColor = text.color;
        text.color = new Color(originalColor.r, originalColor.g, originalColor.b, 0f);

        // 페이드 아웃
        yield return StartCoroutine(FadeOut(text));

        // 텍스트를 화면에 표시합니다.
        yield return new WaitForSeconds(displayDuration);

        // 페이드 인
        yield return StartCoroutine(FadeIn(text));

        // 스크립트가 끝나면 게임 오브젝트를 비활성화합니다.
        gameObject.SetActive(false);
    }

    private IEnumerator FadeOut(Text text)
    {
        float elapsedTime = 0f;
        Color originalColor = text.color;

        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;
            float alpha = Mathf.Lerp(1f, 0f, elapsedTime / fadeDuration);
            text.color = new Color(originalColor.r, originalColor.g, originalColor.b, alpha);
            yield return null;
        }
    }

    private IEnumerator FadeIn(Text text)
    {
        float elapsedTime = 0f;
        Color originalColor = text.color;

        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;
            float alpha = Mathf.Lerp(0f, 1f, elapsedTime / fadeDuration);
            text.color = new Color(originalColor.r, originalColor.g, originalColor.b, alpha);
            yield return null;
        }
    }
}
