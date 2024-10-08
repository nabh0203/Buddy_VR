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
        if (other.CompareTag("Teleport")) // 충돌한 오브젝트가 "Player" 태그를 가지고 있다면
        {
            SceneManager.LoadScene(nextSceneName);
        }
        else
        {
            Debug.Log("아이템을 소지하고 있으시지 않습니다.");
        }
    }
    public string[] forbiddenTags; // 자식으로 상속하지 못하게 할 태그들

    private void Awake()
    {
        CheckChildrenTags(transform);
    }

    private void CheckChildrenTags(Transform parent)
    {
        foreach (Transform child in parent)
        {
            // 자식 오브젝트의 태그를 체크
            if (ContainsForbiddenTag(child.tag))
            {
                // 자식 오브젝트의 태그가 금지된 태그에 포함되어 있다면, 태그를 변경하거나 자식 오브젝트를 제거하는 등의 처리를 수행
                Debug.LogWarning("자식 오브젝트 " + child.name + " 의 태그가 중복되는 태그를 포함하고 있습니다. 처리를 수행하세요.");
            }

            // 자식 오브젝트의 자식에 대해 재귀적으로 체크
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

