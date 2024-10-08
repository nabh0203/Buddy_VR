using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBLock : MonoBehaviour
{
    public string[] allowedTags; // 상속 가능한 태그 배열

    private bool isInherited = false;

    private void Awake()
    {
        // 이미 상속 받은 경우 스크립트를 비활성화합니다.
        if (isInherited)
        {
            enabled = false;
            return;
        }

        // 다른 오브젝트에서 자신을 찾습니다.
        GameObject[] objects = GameObject.FindGameObjectsWithTag(gameObject.tag);

        // 자신을 제외한 다른 오브젝트가 자신을 상속받았는지 검사합니다.
        foreach (GameObject obj in objects)
        {
            if (obj != gameObject && obj.GetComponentInChildren(GetType()) != null)
            {
                isInherited = true;
                enabled = false;
                return;
            }
        }

        // 상속 가능한 태그 중 하나에 속한 경우 태그를 추가합니다.
        if (ArrayContainsTag(allowedTags))
        {
            gameObject.tag = allowedTags[0]; // 첫 번째 태그로 대체합니다.
        }
        else // 상속 가능한 태그가 아닌 경우 스크립트를 비활성화합니다.
        {
            enabled = false;
        }
    }

    // 배열에 태그가 포함되어 있는지 검사하는 메서드입니다.
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
