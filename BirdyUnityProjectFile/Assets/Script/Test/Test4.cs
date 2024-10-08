using UnityEngine;
using UnityEngine.UI;

public class Test4 : MonoBehaviour
{
    public GameObject[] items; // ������ �������� GameObject �迭
    public Button[] buttons; // ��ư�� ������ ���� �迭
    public Camera mainCamera; // ���� ī�޶�
    public Camera alternateCamera; // �������� �� �� ���� ��ü ī�޶�
    private bool isAlternateCameraActive = false; // ��ü ī�޶� Ȱ��ȭ ���θ� �����ϴ� ����
    public string otherTag = "Block";

    private void Start()
    {
        // ��ư ��Ȱ��ȭ
        foreach (Button button in buttons)
        {
            button.gameObject.SetActive(false);
        }
    }

    // �ٸ� ī�޶�� ���� �̵��ϴ� �Լ�
    public void SwitchToOtherCamera()
    {
        mainCamera.enabled = false; // ���� ī�޶� ��Ȱ��ȭ
        alternateCamera.enabled = true; // �ٸ� ī�޶� Ȱ��ȭ
    }

    // ��ư�� �������� �� ȣ��Ǵ� �Լ�
    public void OnButtonClick()
    {
        Debug.Log("��ư�� �����߽��ϴ�. ���� ī�޶�� �����մϴ�.");
        // ��ü ī�޶� Ȱ��ȭ�� ��� ��Ȱ��ȭ
        if (isAlternateCameraActive)
        {
            alternateCamera.gameObject.SetActive(false);
            isAlternateCameraActive = false;
            mainCamera.gameObject.SetActive(true);

            // ��ư ��Ȱ��ȭ
            foreach (Button button in buttons)
            {
                button.gameObject.SetActive(false);
            }

            // ������ ������Ʈ�� �÷��̾��� �ڽ� ������Ʈ�� �����ϰ� ��Ȱ��ȭ
            foreach (GameObject item in items)
            {
                item.transform.SetParent(transform);
                item.GetComponent<Renderer>().enabled = false;
            }

            GameObject[] otherObjects = GameObject.FindGameObjectsWithTag(otherTag);
            foreach (GameObject obj in otherObjects)
            {
                Destroy(obj);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Item"))
        {
            Debug.Log("������ �������� �浹�Ͽ����ϴ�. ī�޶� ��ȯ�մϴ�.");

            // ��ü ī�޶� ��Ȱ��ȭ�� ��� Ȱ��ȭ
            if (!isAlternateCameraActive)
            {
                alternateCamera.gameObject.SetActive(true);
                isAlternateCameraActive = true;
                mainCamera.gameObject.SetActive(false);
                // ��ư Ȱ��ȭ
                foreach (Button button in buttons)
                {
                    button.gameObject.SetActive(true);
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Item"))
        {
            Debug.Log("������ �������� �浹�� ������ϴ�.");
            // ��ư ���� ���ο� ���� ī�޶� ����
            if (!isAlternateCameraActive)
            {
                mainCamera.gameObject.SetActive(true);
            }
        }
        foreach (GameObject item in items)
        {
            item.GetComponent<Renderer>().enabled = true;
        }
    }
}
