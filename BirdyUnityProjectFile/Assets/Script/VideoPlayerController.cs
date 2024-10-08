using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class VideoPlayerController : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public string nextSceneName;

    void Start()
    {
        // 영상 재생이 끝나면 OnVideoFinished 함수 호출
        videoPlayer.loopPointReached += OnVideoFinished;
    }

    void OnVideoFinished(VideoPlayer player)
    {
        // 씬 전환
        SceneManager.LoadScene(nextSceneName);
    }
}

