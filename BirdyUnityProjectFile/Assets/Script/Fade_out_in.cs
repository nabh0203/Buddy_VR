using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Fade_out_in : MonoBehaviour
{
    public Image fadeImage;
    public float fadeSpeed;

    private void Start()
    {
        fadeImage.color = Color.black;
        fadeImage.CrossFadeAlpha(0f, fadeSpeed, false);
    }

    public void OnButtonClick()
    {
        StartCoroutine(TransitionToNextScene());
    }

    private IEnumerator TransitionToNextScene()
    {
        fadeImage.CrossFadeAlpha(1f, fadeSpeed, false);
        yield return new WaitForSeconds(fadeSpeed);
        SceneManager.LoadScene("NextScene");
    }
}
