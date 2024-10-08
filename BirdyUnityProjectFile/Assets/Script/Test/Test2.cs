using UnityEngine;
using UnityEngine.UI;

public class Test2 : MonoBehaviour
{
    public GameObject item;
    public GameObject item2;
    public GameObject item3;
    public GameObject item4; // ������ �������� GameObject
    public Camera mainCamera; // ���� ī�޶�
    public Camera alternateCamera; // �������� �� �� ���� ��ü ī�޶�
    public Button myButton; // ��ư�� ������ ����
    public Button myButton1; // ��ư�� ������ ����
    private bool isAlternateCameraActive = false; // ��ü ī�޶� Ȱ��ȭ ���θ� �����ϴ� ����
    public string otherTag = "Block";

    private void Start()
    {
        // ��ư ��Ȱ��ȭ
        myButton.gameObject.SetActive(false);
        // ��ư ��Ȱ��ȭ
        myButton1.gameObject.SetActive(false);
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
            myButton.gameObject.SetActive(false);
            myButton1.gameObject.SetActive(false);

            // ������ ������Ʈ�� �÷��̾��� �ڽ� ������Ʈ�� �����ϰ� ��Ȱ��ȭ
            item.transform.SetParent(transform);
            item.GetComponent<Renderer>().enabled = false;
            item2.transform.SetParent(transform);
            item2.GetComponent<Renderer>().enabled = false;
            item3.transform.SetParent(transform);
            item3.GetComponent<Renderer>().enabled = false;
            item4.transform.SetParent(transform);
            item4.GetComponent<Renderer>().enabled = false;
            GameObject[] otherObjects = GameObject.FindGameObjectsWithTag(otherTag);
            foreach (GameObject obj in otherObjects)
            {
                Destroy(obj);
            }
        }
    }
    public void OnButtonClick1()
    {
        Debug.Log("��ư�� �����߽��ϴ�. ���� ī�޶�� �����մϴ�.");
        // ��ü ī�޶� Ȱ��ȭ�� ��� ��Ȱ��ȭ
        if (isAlternateCameraActive)
        {
            alternateCamera.gameObject.SetActive(false);
            isAlternateCameraActive = false;
            mainCamera.gameObject.SetActive(true);

            // ��ư ��Ȱ��ȭ
            myButton.gameObject.SetActive(false);
            myButton1.gameObject.SetActive(false);

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
                myButton.gameObject.SetActive(true);
                myButton1.gameObject.SetActive(true);
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
        item.GetComponent<Renderer>().enabled = true;
    }
}