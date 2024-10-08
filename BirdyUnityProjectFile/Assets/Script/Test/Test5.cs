using UnityEngine;
using UnityEngine.UI;

public class Test5 : MonoBehaviour
{
    public GameObject[] items; // ������ �������� GameObject �迭
    public Button[] buttons; // ��ư�� ������ ���� �迭
    public string otherTag = "Block";

    private void Start()
    {
        // ��ư ��Ȱ��ȭ
        foreach (Button button in buttons)
        {
            button.gameObject.SetActive(false);
        }
    }

    // ��ư�� �������� �� ȣ��Ǵ� �Լ�
    public void OnButtonClick()
    {
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
        foreach (Button button in buttons)
        {
            button.gameObject.SetActive(false);
        }  
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Item"))
        {
                // ��ư Ȱ��ȭ
                foreach (Button button in buttons)
                {
                    button.gameObject.SetActive(true);
                }
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        foreach (GameObject item in items)
        {
            item.GetComponent<Renderer>().enabled = true;
        }
    }
}
