using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VR_FadeTest : MonoBehaviour
{
    // Start is called before the first frame update
    private Image img;
    public float duration = 1.0f;
    public bool isVisible;

    private void Start()
    {
        img = gameObject.GetComponent<Image>();
    }

    public void SetReverseUIFade(float level)
    {
        img.CrossFadeAlpha(level, duration, false);
    }

    public void SetExplicitFade(float level)
    {
        img.CrossFadeAlpha(level, duration, false);
    }

    public void FadeIn()
    {
        img.enabled = true;
        isVisible = true;
        SetReverseUIFade(0f);
    }

    public void FadeOut()
    {
        img.enabled = true;
        isVisible = false;
        SetReverseUIFade(0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
