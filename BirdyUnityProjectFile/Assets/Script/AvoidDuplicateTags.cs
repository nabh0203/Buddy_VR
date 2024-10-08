using UnityEngine;

public class AvoidDuplicateTags : MonoBehaviour
{
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
