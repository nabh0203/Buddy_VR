using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSelector3 : MonoBehaviour
{
    public GameObject objectToSelect; // ������ ������Ʈ
    public GameObject button; // ��Ÿ�� ��ư
    public Camera mainCamera; // ���� ī�޶�
    public Transform startingPosition; // ó�� ��ġ
    public GameObject player; // �÷��̾� ������Ʈ

    private bool isItemSelected = false; // �������� ���õǾ����� ����
    private Vector3 originalObjectPosition; // ������Ʈ�� ���� ��ġ
    private Quaternion originalObjectRotation; // ������Ʈ�� ���� ȸ����
    private Camera originalCamera; // ���� ����ϴ� ī�޶�

    void Start()
    {
        // ���� ī�޶� ã�� Ȱ��ȭ
        Camera.main.enabled = true;

        // ������Ʈ�� ���� ��ġ�� ȸ���� ����
        originalObjectPosition = objectToSelect.transform.position;
        originalObjectRotation = objectToSelect.transform.rotation;

        // ��ư ��Ȱ��ȭ
        button.SetActive(false);

        // ���� ����ϴ� ī�޶� ����
        originalCamera = mainCamera;
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
            // ������Ʈ�� ���� ��ġ�� ȸ�������� ����
            objectToSelect.transform.position = originalObjectPosition;
            objectToSelect.transform.rotation = originalObjectRotation;

            // ���� ����ϴ� ī�޶�� ��ȯ
            mainCamera.enabled = false;
            originalCamera.enabled = true;
            mainCamera = originalCamera;

            // ��ư Ȱ��ȭ
            button.SetActive(true);
        }
    }

    public void OnButtonClick()
    {
        if (!isItemSelected)
        {
            // �������� ���õǾ����� ���� ��ġ�� ȸ�������� �̵�
            objectToSelect.transform.position = originalObjectPosition;
            objectToSelect.transform.rotation = originalObjectRotation;

            // ī�޶� ��ġ�� �þ߰� �ʱ�ȭ
            mainCamera.transform.position = startingPosition.position;
            mainCamera.transform.LookAt(objectToSelect.transform);
            mainCamera.fieldOfView = 60.0f;

            // ��ư ��Ȱ��ȭ �� ������ ���� ���� �ʱ�ȭ
            button.SetActive(false);
            isItemSelected = false;
        }
        else
        {
            // �������� ���õ� �����̸� ���õ� �������� ��� ó���� ����
            // ���⿡ ���õ� �������� ��� �ڵ带 �߰��ϼ���
            Debug.Log("�������� ������ϴ�: " + objectToSelect.name);

            // �������� ���� ��, ������Ʈ�� ��Ȱ��ȭ�ϰ�, �������� ���õ� ���¸� true�� ����
            objectToSelect.SetActive(false);
            isItemSelected = true;
        }
    }
}
