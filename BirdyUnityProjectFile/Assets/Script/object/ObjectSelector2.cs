using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ObjectSelector2 : MonoBehaviour
{
    public GameObject objectToSelect; // ������ ������Ʈ
    public GameObject button; // ��Ÿ�� ��ư
    public Camera mainCamera; // ���� ī�޶�
    public Transform startingPosition; // ó�� ��ġ
    public GameObject player; // �÷��̾� ������Ʈ

    private bool isItemSelected = false; // �������� ���õǾ����� ����
    private Vector3 originalObjectPosition; // ������Ʈ�� ���� ��ġ
    private Quaternion originalObjectRotation; // ������Ʈ�� ���� ȸ����

    void Start()
    {
        // ���� ī�޶� ã�� Ȱ��ȭ
        Camera.main.enabled = true;

        // ������Ʈ�� ���� ��ġ�� ȸ���� ����
        originalObjectPosition = objectToSelect.transform.position;
        originalObjectRotation = objectToSelect.transform.rotation;

        // ��ư ��Ȱ��ȭ
        button.SetActive(false);
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
            // ������Ʈ�� ī�޶��� �Ÿ��� ���
            float distance = Vector3.Distance(objectToSelect.transform.position, mainCamera.transform.position);

            // ������Ʈ�� ī�޶��� �Ÿ��� ���� ���� �̳��� ��쿡�� ����
            if (distance < 0.3f)
            {
                // ������Ʈ�� ���� ��ġ�� ȸ�������� ����
                objectToSelect.transform.position = originalObjectPosition;
                objectToSelect.transform.rotation = originalObjectRotation;

                // ī�޶� ��ȯ
                mainCamera.transform.position = objectToSelect.transform.position;
                mainCamera.transform.LookAt(objectToSelect.transform);
                mainCamera.fieldOfView = 60.0f;

                // ��ư Ȱ��ȭ
                button.SetActive(true);
            }
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

            // �������� ���� ��, ������Ʈ�� ��Ȱ��ȭ�ϰ�, �θ� player�� ����
            objectToSelect.SetActive(false);
            objectToSelect.transform.SetParent(player.transform, true); // true�� �Ѱܼ� worldPositionStays�� true�� ����

            // ī�޶� �÷��̾� ������Ʈ�� ��ġ��Ű�� �þ߰� �ʱ�ȭ
            mainCamera.transform.position = player.transform.position;
            mainCamera.transform.rotation = player.transform.rotation;
            mainCamera.fieldOfView = 60.0f;

            // ��ư Ȱ��ȭ �� ������ ���� ���� ������Ʈ
            button.SetActive(true);
            isItemSelected = true;
        }
    }
}