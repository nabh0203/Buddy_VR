using UnityEngine;
using UnityEngine.SceneManagement;

public class ItemTag : MonoBehaviour
{
    public string nextSceneName; // 다음 씬의 이름
    private string requiredKeyTag = "Item"; // 요구되는 키의 태그 이름

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // 충돌한 오브젝트가 "Player" 태그를 가지고 있다면
        {
            // 요구되는 키가 있는지 체크
            GameObject[] keyObjects = GameObject.FindGameObjectsWithTag(requiredKeyTag);
            bool hasRequiredKey = false;

            foreach (GameObject keyObject in keyObjects)
            {
                // 상속된 태그인지 확인
                if (keyObject.CompareTag(requiredKeyTag) || keyObject.GetComponentInChildren<ItemTag>() != null)
                {
                    hasRequiredKey = true;
                    break;
                }
            }

            if (hasRequiredKey)
            {
                Debug.Log("아이템이 있으십니다 이동하겠습니다.");
                // 키 오브젝트가 있는 경우, 다음 씬으로 전환
                SceneManager.LoadScene(nextSceneName);
            }
            else
            {
                // 키 오브젝트가 없는 경우, 메시지 출력 또는 다른 처리
                Debug.Log("키가 없어서 다음 씬으로 이동할 수 없습니다.");
            }
        }
    }

}