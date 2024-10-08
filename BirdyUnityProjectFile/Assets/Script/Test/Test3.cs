using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test3 : MonoBehaviour
{
    public GameObject item; // ������ �������� GameObject
    public Camera mainCamera; // ���� ī�޶�
    public Camera alternateCamera; // �������� �� �� ���� ��ü ī�޶�
    public Button myButton; // ��ư�� ������ ����
    public Button myButton1; // ��ư�� ������ ����
    private bool isAlternateCameraActive = false; // ��ü ī�޶� Ȱ��ȭ ���θ� �����ϴ� ����
    // ��ӹ��� ������Ʈ�� �ʱ� ����
    private void Awake()
    {
        transform.position = new Vector3(transform.position.x, -100f, transform.position.z);
    }

    // ��ӹ��� ������Ʈ�� ���� ����
    private void Start()
    {
        myButton.gameObject.SetActive(false);
        myButton1.gameObject.SetActive(false);
    }

    // ��ӹ��� ������Ʈ�� ��ư ���ý� ����
    public void OnButtonClick()
    {
        Debug.Log("��ư�� �����߽��ϴ�. ���� ī�޶�� �����մϴ�.");
        // ��ü ī�޶� Ȱ��ȭ�� ��� ��Ȱ��ȭ
        if (isAlternateCameraActive)
        {
            alternateCamera.gameObject.SetActive(false);
            isAlternateCameraActive = false;
            mainCamera.gameObject.SetActive(true);

            Renderer itemRenderer = item.GetComponent<Renderer>();
            if (itemRenderer != null)
            {
                item.transform.SetParent(transform);
                Color itemColor = itemRenderer.material.color;
                itemColor.a = 0f;
                itemRenderer.material.color = itemColor;
            }

            myButton.gameObject.SetActive(false);
            myButton1.gameObject.SetActive(false);
        }
    }

    // �浹�� ����
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Item"))
        {
            Debug.Log("������ �������� �浹�Ͽ����ϴ�. ī�޶� ��ȯ�մϴ�.");

            if (!isAlternateCameraActive)
            {
                alternateCamera.gameObject.SetActive(true);
                isAlternateCameraActive = true;
                mainCamera.gameObject.SetActive(false);
                myButton.gameObject.SetActive(true);
                myButton1.gameObject.SetActive(true);
            }
        }
    }

    // �浹 ����� �� ����
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Item"))
        {
            Debug.Log("������ �������� �浹�� ������ϴ�.");
        }
    }
}

