using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{
    public GameObject target; // �÷��̾�� ��ӵ� Ÿ�� ������Ʈ
    public Button[] buttons; // ��ư�� ������ �迭 ����

    public void InheritToPlayer()
    {
        target.transform.parent = GameObject.FindGameObjectWithTag("Player").transform; // Ÿ�� ������Ʈ�� �÷��̾��� �ڽ� ������Ʈ�� ����ϴ�.
        target.transform.localPosition = Vector3.zero; // Ÿ�� ������Ʈ�� ���� ��ġ�� (0, 0, 0)���� �����մϴ�.
        target.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f); // Ÿ�� ������Ʈ�� �������� (0.5, 0.5, 0.5)���� �����մϴ�.
        foreach (Transform child in transform)
        {
            Button[] childButtons = child.GetComponentsInChildren<Button>();
            foreach (Button button in childButtons)
            {
                button.gameObject.SetActive(false);
            }
        }
    }
}
