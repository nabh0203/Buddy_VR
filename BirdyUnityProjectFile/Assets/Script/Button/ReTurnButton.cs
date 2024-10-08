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

        // ��ư�� Ŭ�� �̺�Ʈ ������ �߰�
        if (button != null)
        {
            button.onClick.AddListener(OnButtonClick);
        }
    }

    private void OnButtonClick()
    {
        // ��ư Ŭ�� �� ���̵� �ƿ� �� ���� ��ġ�� �̵��ϴ� �ڷ�ƾ ����
        StartCoroutine(FadeOutAndMoveBackCoroutine());
    }

    public IEnumerator FadeOutAndMoveBackCoroutine()
    {
        // ���̵� �ƿ�
        float elapsedTime = 0;
        while (elapsedTime < fadeOutDuration)
        {
            float alpha = Mathf.Lerp(1f, 0f, elapsedTime / fadeOutDuration);
            image.color = new Color(image.color.r, image.color.g, image.color.b, alpha);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // ���� ��ġ�� �̵�
        Vector3 startPos = transform.position;
        Vector3 endPos = originalPosition;
        elapsedTime = 0;
        while (elapsedTime < moveBackDuration)
        {
            transform.position = Vector3.Lerp(startPos, endPos, elapsedTime / moveBackDuration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // �ʱ� ���·� ����
        transform.position = originalPosition;
        image.color = new Color(image.color.r, image.color.g, image.color.b, 1f);
    }
}


