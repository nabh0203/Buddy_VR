using UnityEngine;
using UnityEngine.UI;

public class Button_Select : MonoBehaviour
{
    public GameObject objectToInherit; // ��ӹ��� ������Ʈ�� Inspector â���� �Ҵ�
    public GameObject parentObject; // ����� �θ� ������Ʈ�� Inspector â���� �Ҵ�

    private void Start()
    {
        // ��ư Ŭ�� �̺�Ʈ�� �޼��� ���
        Button button = GetComponent<Button>();
        button.onClick.AddListener(InheritObject);
    }

    public void InheritObject()
    {
        // ��ư�� Ŭ���Ǹ� objectToInherit�� parentObject�� �ڽ� ������Ʈ�� �߰�
        objectToInherit.transform.SetParent(parentObject.transform, true);
        objectToInherit.SetActive(false); // �߰��� ������Ʈ�� ��Ȱ��ȭ
    }
}


