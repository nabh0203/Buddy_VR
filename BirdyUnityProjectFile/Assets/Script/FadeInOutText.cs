using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class FadeInOutText : MonoBehaviour
{
    public float fadeDuration = 1.5f;  // ���̵� ��/�ƿ� ���ӽð�
    public float displayDuration = 2.0f;  // �ؽ�Ʈ�� ȭ�鿡 ǥ�õǴ� �ð�
    public Text text;  // ȭ�鿡 ��Ÿ�� �ؽ�Ʈ

    private IEnumerator Start()
    {
        // �ʱ⿡�� �ؽ�Ʈ�� �����ϰ� ����ϴ�.
        Color originalColor = text.color;
        text.color = new Color(originalColor.r, originalColor.g, originalColor.b, 0f);

        // ���̵� �ƿ�
        yield return StartCoroutine(FadeOut(text));

        // �ؽ�Ʈ�� ȭ�鿡 ǥ���մϴ�.
        yield return new WaitForSeconds(displayDuration);

        // ���̵� ��
        yield return StartCoroutine(FadeIn(text));

        // ��ũ��Ʈ�� ������ ���� ������Ʈ�� ��Ȱ��ȭ�մϴ�.
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
