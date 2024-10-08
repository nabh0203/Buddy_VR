using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
        // 전환할 씬의 이름을 저장할 변수
        public string sceneName;

        // 버튼이 클릭되었을 때 호출될 함수
        public void OnButtonClick()
        {
            // 지정한 씬으로 전환
            SceneManager.LoadScene(sceneName);
        }
}
