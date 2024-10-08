using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class ShowButton_Scenemove : MonoBehaviour
{
    public VideoPlayer videoPlayer; // ���� �÷��̾� ������Ʈ
    public GameObject button; // ������ ��ư ������Ʈ
    public string nextSceneName; // ���� ���� �̸�

    void Start()
    {
        // ���� �÷��̾��� �̺�Ʈ ������ ���
        videoPlayer.loopPointReached += OnVideoEnded;
    }

    // ������ ������ ȣ��Ǵ� �Լ�
    void OnVideoEnded(VideoPlayer vp)
    {
        // ��ư ������Ʈ�� Ȱ��ȭ�Ͽ� ���̰� ��
        button.SetActive(true);
    }

    // ��ư Ŭ�� �� ȣ��� �Լ�
    public void OnButtonClick()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}
