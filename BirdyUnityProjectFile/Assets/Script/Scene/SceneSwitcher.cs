using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
        // ��ȯ�� ���� �̸��� ������ ����
        public string sceneName;

        // ��ư�� Ŭ���Ǿ��� �� ȣ��� �Լ�
        public void OnButtonClick()
        {
            // ������ ������ ��ȯ
            SceneManager.LoadScene(sceneName);
        }
}
