using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonFade : MonoBehaviour
{
    // ��ư�� CanvasGroup ������Ʈ�� ������ ����
    public CanvasGroup buttonCanvasGroup;
    // ���̵� �ο� �ɸ��� �ð�
    public float fadeInDuration = 1.0f;

    // Start �Լ����� ���̵� �� �ִϸ��̼��� ����
    void Start()
    {
        // ��ư�� CanvasGroup ������Ʈ�� Alpha ���� 0���� ����
        buttonCanvasGroup.alpha = 0;
        // ���̵� �� �ִϸ��̼� ����
        StartCoroutine(FadeInButton());
    }

    // ���̵� �� �ִϸ��̼� �ڷ�ƾ �Լ�
    IEnumerator FadeInButton()
    {
        // ���̵� �ο� ����� �ð� ���� �ʱ�ȭ
        float elapsedTime = 0;

        // �ð��� ���̵� �ο� �ɸ��� �ð����� ���� ���� �ݺ�
        while (elapsedTime < fadeInDuration)
        {
            // ��ư�� CanvasGroup ������Ʈ�� Alpha ���� �ð��� ���� �������� ���̵� �� ȿ�� ����
            buttonCanvasGroup.alpha = Mathf.Lerp(0, 1, elapsedTime / fadeInDuration);
            // ��� �ð� ������Ʈ
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // ���̵� ���� �Ϸ�Ǹ� CanvasGroup ������Ʈ�� Ȱ��ȭ�Ͽ� ��ư�� ���ͷ�Ƽ���ϰ� �����ϵ��� ����
        buttonCanvasGroup.alpha = 1;
        buttonCanvasGroup.interactable = true;
        buttonCanvasGroup.blocksRaycasts = true;
    }
}
