using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public float fadeDuration = 1.0f;
    public string nextSceneName;

    private IEnumerator Start()
    {
        videoPlayer.loopPointReached += OnVideoEnd;
        videoPlayer.Play();
        yield return new WaitForSeconds((float)videoPlayer.clip.length);
        OnVideoEnd(videoPlayer);
    }

    private void OnVideoEnd(VideoPlayer vp)
    {
        StartCoroutine(FadeOut());
    }

    private IEnumerator FadeOut()
    {
        CanvasGroup canvasGroup = GetComponent<CanvasGroup>();
        float t = 0.0f;
        while (t < fadeDuration)
        {    
            t += Time.deltaTime;
            float alpha = Mathf.Lerp(0.0f, 1.0f, t / fadeDuration);
            canvasGroup.alpha = alpha;
            yield return null;
        }
        SceneManager.LoadScene(nextSceneName);
    }
}
