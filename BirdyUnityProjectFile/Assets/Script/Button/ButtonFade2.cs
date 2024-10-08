using UnityEngine;
using UnityEngine.Video;

public class ButtonFade2 : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public GameObject button;

    private bool buttonVisible;

    void Start()
    {
        button.SetActive(false);
        buttonVisible = false;
    }

    void Update()
    {
        if (videoPlayer.time >= 28.0f && !buttonVisible)
        {
            button.SetActive(true);
            buttonVisible = true;
        }
    }
}
