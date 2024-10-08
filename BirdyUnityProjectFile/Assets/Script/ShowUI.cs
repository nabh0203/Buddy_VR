/*using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ShowUI : MonoBehaviour
{
    public float delayTime = 2.0f;
    public List<RawImage> type1UIImages;
    public List<CanvasGroup> type2UICanvasGroup;

    void Start()
    {
        // Start 시 실행할 내용
    }

    public void ShowType1UI()
    {
        StartCoroutine(ShowType1UIDelay());
    }

    IEnumerator ShowType1UIDelay()
    {
        yield return new WaitForSeconds(delayTime);
        foreach (RawImage img in type1UIImages)
        {
            img.gameObject.SetActive(true);
        }
        StartCoroutine(HideType1UIDelay());
    }

    IEnumerator HideType1UIDelay()
    {
        yield return new WaitForSeconds(4.0f);
        foreach (RawImage img in type1UIImages)
        {
            img.gameObject.SetActive(false);
        }
    }

    public void ShowType2UI()
    {
        StartCoroutine(ShowType2UIDelay());
    }

    IEnumerator ShowType2UIDelay()
    {
        yield return new WaitForSeconds(delayTime);
        foreach (CanvasGroup canvasGroup in type2UICanvasGroup)
        {
            canvasGroup.gameObject.SetActive(true);
        }
    }

    public void OnButtonClick()
    {
        foreach (CanvasGroup canvasGroup in type2UICanvasGroup)
        {
            canvasGroup.gameObject.SetActive(false);
        }
    }
}
*/