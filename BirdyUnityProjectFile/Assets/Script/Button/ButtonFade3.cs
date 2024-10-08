using UnityEngine;
using UnityEngine.UI;

public class ButtonFade3 : MonoBehaviour
{
    public Button button;
    public float timeBeforeFade = 30.0f;
    public float fadeDuration = 1.0f;

    private CanvasGroup canvasGroup;
    private float currentFadeTime = 0.0f;
    private bool isFading = false;

    void Start()
    {
        canvasGroup = button.GetComponent<CanvasGroup>();
        canvasGroup.alpha = 0.0f;
    }

    void Update()
    {
        currentFadeTime += Time.deltaTime;

        if (!isFading && currentFadeTime >= timeBeforeFade)
        {
            isFading = true;
        }

        if (isFading)
        {
            canvasGroup.alpha += Time.deltaTime / fadeDuration;

            if (canvasGroup.alpha >= 1.0f)
            {
                canvasGroup.alpha = 1.0f;
                isFading = false;
            }
        }
    }
}
