using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ObjectSelector : MonoBehaviour
{
    public GameObject objectToSelect; // ������ ������Ʈ
    public GameObject button; // ��Ÿ�� ��ư
    public Camera mainCamera; // ���� ī�޶�
    public Camera otherCamera;
    public Transform startingPosition; // ó�� ��ġ
    public float fadeOutDuration = 2.0f; // Fade Out�� �ɸ��� �ð�
    private bool isItemSelected = false; // �������� ���õǾ����� ����
    void Start()
    {
        // ���� ī�޶� ã�� Ȱ��ȭ
        Camera.main.enabled = true;
    }
    void Awake()
    {
        // mainCamera ������ ���� Scene���� "Main Camera" �±׸� ���� ī�޶� ã�� �Ҵ�
        mainCamera = Camera.main;
    }
    void Update()
    {
        // ������ ������Ʈ�� Ȱ��ȭ�Ǿ� �ְ� �����̽��ٸ� ���� ���
        if (objectToSelect.activeSelf && !isItemSelected && Input.GetKeyDown(KeyCode.Space))
        {
            // ī�޶� ��ȯ
            mainCamera.transform.position = objectToSelect.transform.position;
            mainCamera.transform.LookAt(objectToSelect.transform);
            mainCamera.fieldOfView = 60.0f;

            // ��ư Ȱ��ȭ
            button.SetActive(true);
        }
    }

    public void SelectObject()
    {
        // ������ ���� �Ϸ� ó��
        Debug.Log("������ ���� �Ϸ�");
        isItemSelected = true;

        // Fade Out �� ó�� ��ġ�� �̵�
        StartCoroutine(FadeOutAndMoveToStartingPosition());
    }

    IEnumerator FadeOutAndMoveToStartingPosition()
    {
        // Fade Out �ִϸ��̼� ó��
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

        // ó�� ��ġ�� �̵�
        mainCamera.transform.position = startingPosition.position;
        mainCamera.transform.rotation = startingPosition.rotation;
        mainCamera.fieldOfView = 60.0f;

        // ��ư ��Ȱ��ȭ �� ������ ���� ���� �ʱ�ȭ
        button.SetActive(false);
        isItemSelected = false;
    }
}
