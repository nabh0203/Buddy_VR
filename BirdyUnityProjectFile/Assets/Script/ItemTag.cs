using UnityEngine;
using UnityEngine.SceneManagement;

public class ItemTag : MonoBehaviour
{
    public string nextSceneName; // ���� ���� �̸�
    private string requiredKeyTag = "Item"; // �䱸�Ǵ� Ű�� �±� �̸�

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // �浹�� ������Ʈ�� "Player" �±׸� ������ �ִٸ�
        {
            // �䱸�Ǵ� Ű�� �ִ��� üũ
            GameObject[] keyObjects = GameObject.FindGameObjectsWithTag(requiredKeyTag);
            bool hasRequiredKey = false;

            foreach (GameObject keyObject in keyObjects)
            {
                // ��ӵ� �±����� Ȯ��
                if (keyObject.CompareTag(requiredKeyTag) || keyObject.GetComponentInChildren<ItemTag>() != null)
                {
                    hasRequiredKey = true;
                    break;
                }
            }

            if (hasRequiredKey)
            {
                Debug.Log("�������� �����ʴϴ� �̵��ϰڽ��ϴ�.");
                // Ű ������Ʈ�� �ִ� ���, ���� ������ ��ȯ
                SceneManager.LoadScene(nextSceneName);
            }
            else
            {
                // Ű ������Ʈ�� ���� ���, �޽��� ��� �Ǵ� �ٸ� ó��
                Debug.Log("Ű�� ��� ���� ������ �̵��� �� �����ϴ�.");
            }
        }
    }

}