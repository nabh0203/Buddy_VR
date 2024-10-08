using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ending_Test : MonoBehaviour
{
    public string nextSceneName;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Teleport")) // �浹�� ������Ʈ�� "Player" �±׸� ������ �ִٸ�
        {
            SceneManager.LoadScene(nextSceneName);
        }
        else
        {
            Debug.Log("�������� �����ϰ� �������� �ʽ��ϴ�.");
        }
    }
    public string[] forbiddenTags; // �ڽ����� ������� ���ϰ� �� �±׵�

    private void Awake()
    {
        CheckChildrenTags(transform);
    }

    private void CheckChildrenTags(Transform parent)
    {
        foreach (Transform child in parent)
        {
            // �ڽ� ������Ʈ�� �±׸� üũ
            if (ContainsForbiddenTag(child.tag))
            {
                // �ڽ� ������Ʈ�� �±װ� ������ �±׿� ���ԵǾ� �ִٸ�, �±׸� �����ϰų� �ڽ� ������Ʈ�� �����ϴ� ���� ó���� ����
                Debug.LogWarning("�ڽ� ������Ʈ " + child.name + " �� �±װ� �ߺ��Ǵ� �±׸� �����ϰ� �ֽ��ϴ�. ó���� �����ϼ���.");
            }

            // �ڽ� ������Ʈ�� �ڽĿ� ���� ��������� üũ
            CheckChildrenTags(child);
        }
    }

    private bool ContainsForbiddenTag(string tag)
    {
        foreach (string forbiddenTag in forbiddenTags)
        {
            if (tag == forbiddenTag)
            {
                return true;
            }
        }
        return false;
    }
}

