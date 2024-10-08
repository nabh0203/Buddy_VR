using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class SelectObject : MonoBehaviour
{
    public string buttonTag; // ��ư �±�
    public GameObject button2;  //������Ʈ ��ӽ� �Ǵٸ� ������Ʈ�� �ֿ�� ��Ÿ���� �ؽ�Ʈ 
    public GameObject Pannel; // �÷��̾�� �������� �ǳ� ������Ʈ
    public GameObject target; // �÷��̾�� ��ӵ� Ÿ�� ������Ʈ
    public GameObject target2; // �÷��̾�� �������� Ÿ�� ������Ʈ
    

    private Button[] buttons; // ��ư�� ������ �迭 ����

    private void Start()
    {
        button2.gameObject.SetActive(false); //�ؽ�Ʈ ��Ȱ��ȭ
        buttons = GameObject.FindGameObjectsWithTag(buttonTag)
                           .Select(go => go.GetComponent<Button>())
                           .ToArray(); // ��ư �迭 �ʱ�ȭ
        foreach (Button button in buttons)
        {
            button.gameObject.SetActive(false); // ��ư ��Ȱ��ȭ
            Pannel.gameObject.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // �÷��̾�� �浹���� ��
        {
            foreach (Button button in buttons)
            {
                if (!button.gameObject.activeSelf) // ��ư�� ��Ȱ��ȭ�� ��쿡�� Ȱ��ȭ�մϴ�.
                {
                    button.gameObject.SetActive(true); // ��ư Ȱ��ȭ
                    Pannel.gameObject.SetActive(true);
                }
            }
        }
    }
    public void InheritToPlayer()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        bool hasOtherTags = false;

        // �÷��̾ �̹� �ٸ� �±׸� ���� ������Ʈ�� ��� �ް� �ִ��� Ȯ���մϴ�.
        foreach (Transform child in player.transform)
        {
            if (child.CompareTag("Window") || child.CompareTag("Cat") || child.CompareTag("Apple") || child.CompareTag("Bread"))
            {
                hasOtherTags = true;
                break;
            }
        }

        // �ٸ� �±׸� ���� ������Ʈ�� ��� �ް� �ִ� ���
        if (hasOtherTags)
        {
            Debug.Log("�̹� �ٸ� �±׸� ���� ������Ʈ�� ��� �ް� �ֽ��ϴ�.");
            foreach (Button button in buttons)
            {
                button.gameObject.SetActive(false); // ��ư ��Ȱ��ȭ
            }
            button2.gameObject.SetActive(true); //�ؽ�Ʈ Ȱ��ȭ
            Pannel.gameObject.SetActive(true); //�ǳ� Ȱ��ȭ
            return;
        }

        // �÷��̾�� ����մϴ�.
        target.transform.parent = player.transform;
        target.transform.localPosition = Vector3.zero;
        target.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);

        // ��ư�� ��Ȱ��ȭ�մϴ�.
        foreach (Button button in buttons)
        {
            button.gameObject.SetActive(false);
            Pannel.gameObject.SetActive(false);
        }

        // SelectObject ��ũ��Ʈ�� ��Ȱ��ȭ�մϴ�.
        target.SetActive(true);
        target2.SetActive(false);
    }



    public void OnButtonClick()
    {
        foreach (Button button in buttons)
        {
            button.gameObject.SetActive(false); // ��ư ��Ȱ��ȭ
            Pannel.gameObject.SetActive(false); // �ǳ� ��Ȱ��ȭ
        }
    }
    public void OnOtherButtonClick(Button otherButton)
    {
        OnButtonClick();

        otherButton.gameObject.SetActive(false);
        button2.gameObject.SetActive(false);
        Pannel.gameObject.SetActive(false);
    }
}
