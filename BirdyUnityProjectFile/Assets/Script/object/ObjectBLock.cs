using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBLock : MonoBehaviour
{
    public string[] allowedTags; // ��� ������ �±� �迭

    private bool isInherited = false;

    private void Awake()
    {
        // �̹� ��� ���� ��� ��ũ��Ʈ�� ��Ȱ��ȭ�մϴ�.
        if (isInherited)
        {
            enabled = false;
            return;
        }

        // �ٸ� ������Ʈ���� �ڽ��� ã���ϴ�.
        GameObject[] objects = GameObject.FindGameObjectsWithTag(gameObject.tag);

        // �ڽ��� ������ �ٸ� ������Ʈ�� �ڽ��� ��ӹ޾Ҵ��� �˻��մϴ�.
        foreach (GameObject obj in objects)
        {
            if (obj != gameObject && obj.GetComponentInChildren(GetType()) != null)
            {
                isInherited = true;
                enabled = false;
                return;
            }
        }

        // ��� ������ �±� �� �ϳ��� ���� ��� �±׸� �߰��մϴ�.
        if (ArrayContainsTag(allowedTags))
        {
            gameObject.tag = allowedTags[0]; // ù ��° �±׷� ��ü�մϴ�.
        }
        else // ��� ������ �±װ� �ƴ� ��� ��ũ��Ʈ�� ��Ȱ��ȭ�մϴ�.
        {
            enabled = false;
        }
    }

    // �迭�� �±װ� ���ԵǾ� �ִ��� �˻��ϴ� �޼����Դϴ�.
    private bool ArrayContainsTag(string[] tags)
    {
        foreach (string tag in tags)
        {
            if (gameObject.CompareTag(tag))
            {
                return true;
            }
        }
        return false;
    }
}
