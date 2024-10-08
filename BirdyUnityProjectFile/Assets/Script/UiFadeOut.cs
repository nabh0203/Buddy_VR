using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiFadeOut : MonoBehaviour
{
    public RawImage rawImage;
    public RawImage rawImage2;
    public GameObject prefab;
    public GameObject d1;
    public GameObject d2;
    

    private float fadeInSpeed = 2f; // 나타나는 속도
    private float fadeOutSpeed = 2f; // 사라지는 속도

    private bool isFadingIn; // 등장 중인지 저장하는 변수
    private bool isFadingOut; // 사라지는 중인지 저장하는 변수

    void Start()
    {
        
        isFadingIn = true;
        rawImage.color = new Color(rawImage.color.r, rawImage.color.g, rawImage.color.b, 0); // 처음에는 alpha값이 0
        

    }

    void Update()
    {
        if (isFadingIn)
            FadeIn(); // 등장 중일 때 실행
        else if (isFadingOut)
            FadeOut(); // 사라지는 중일 때 실행
    }

    void FadeIn()
    {
        rawImage.color += new Color(0, 0, 0, fadeInSpeed * Time.deltaTime);

        if (rawImage.color.a >= 1)
        {
            isFadingIn = false;
            StartCoroutine(FadeOutDelay());
        }
    }

    IEnumerator FadeOutDelay()
    {
        yield return new WaitForSeconds(4f); // 4초 기다린 후 사라지기 시작

        isFadingOut = true;
    }

    void FadeOut()
    {
        rawImage.color -= new Color(0, 0, 0, fadeOutSpeed * Time.deltaTime);

        if (rawImage.color.a <= 0)
        {
            isFadingOut = false;
            rawImage.enabled = false;
        }
        if (rawImage.enabled == false)
        {
            d1.SetActive(true);
            Instantiate(prefab, new Vector3(0.8f, 0f, -19.51f), Quaternion.identity);

        }
        
    }
    /*private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("TeleportTrigger"))
        {
            Debug.Log("트리거");
            rawImage2.enabled = true;
            Instantiate(prefab, new Vector3(0.8f, 0f, -14.35f), Quaternion.identity);
            Instantiate(prefab, new Vector3(0.8f, 0f, -11.04f), Quaternion.identity);
            Instantiate(prefab, new Vector3(0.8f, 0f, -7.81f), Quaternion.identity);
            Instantiate(prefab, new Vector3(0.8f, 0f, -4.536f), Quaternion.identity);
            Instantiate(prefab, new Vector3( 0.58f, 0f,- 1.78f), Quaternion.identity);
            Instantiate(prefab, new Vector3(0.58f, 0f, 0.57f), Quaternion.identity);
            Instantiate(prefab, new Vector3(0.11f, 0f, 4.86f), Quaternion.identity);
            Instantiate(prefab, new Vector3(0.11f, 0f, 7.98f), Quaternion.identity);
            Instantiate(prefab, new Vector3(0.11f, 0f, 7.98f), Quaternion.identity);
            Instantiate(prefab, new Vector3(-0.053f, 0f, 13.149f), Quaternion.identity);
        }
       
    }
*/
    /*private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("TeleportTrigger"))
        {
            rawImage2.enabled = false;
        }
    }*/
}
