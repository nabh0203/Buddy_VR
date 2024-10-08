using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class ShowButton_Scenemove : MonoBehaviour
{
    public VideoPlayer videoPlayer; // 비디오 플레이어 컴포넌트
    public GameObject button; // 보여질 버튼 오브젝트
    public string nextSceneName; // 다음 씬의 이름

    void Start()
    {
        // 비디오 플레이어의 이벤트 리스너 등록
        videoPlayer.loopPointReached += OnVideoEnded;
    }

    // 비디오가 끝나면 호출되는 함수
    void OnVideoEnded(VideoPlayer vp)
    {
        // 버튼 오브젝트를 활성화하여 보이게 함
        button.SetActive(true);
    }

    // 버튼 클릭 시 호출될 함수
    public void OnButtonClick()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}
