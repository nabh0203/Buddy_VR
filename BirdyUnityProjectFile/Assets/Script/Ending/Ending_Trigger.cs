using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ending_Trigger : MonoBehaviour
{
    public string nextSceneName; // ���� ���� �̸�
    private string requiredKeyTag = "Item"; // �䱸�Ǵ� Ű�� �±� �̸�

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // �浹�� ������Ʈ�� "Player" �±׸� ������ �ִٸ�
        {
            // �䱸�Ǵ� Ű�� �ִ��� üũ
            GameObject keyObject = GameObject.FindGameObjectWithTag(requiredKeyTag);
            if (keyObject != null && keyObject.CompareTag("Item")) // ������ �κ�: ��ӹ��� �±� üũ
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