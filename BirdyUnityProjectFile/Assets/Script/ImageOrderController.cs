/*using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
public class ImageOrderController : MonoBehaviour
{
    [SerializeField] public Canvas CanvasType1;
    [SerializeField] public Canvas CanvasType2;
    [SerializeField] public Button NextButton;

    private int CurrentCanvasIndex = 0;
    private int CurrentImageIndex = 0;
    private List<RawImage> ImagesList = new List<RawImage>();

    void Start()
    {
        // ������ ĵ������ �ִ� RawImage���� ����Ʈ�� ����.
        ImagesList.AddRange(CanvasType1.GetComponentsInChildren<RawImage>());
        ImagesList.AddRange(CanvasType2.GetComponentsInChildren<RawImage>());

        // ó������ ù ��° ĵ������ Ȱ��ȭ�Ͽ� ������.
        CanvasType1.gameObject.SetActive(true);
        CanvasType2.gameObject.SetActive(false);

        // ���� �̹����� �����ִ� ��ư(NextButton)�� ���� Ŭ�� �̺�Ʈ�� ���
        NextButton.onClick.AddListener(() =>
        {
            NextImage();
        });
        SetCurrentImage();  
    }

    private void NextImage()
    {
        // ���� �̹����� �Ѿ�鼭, ĵ������ ������ �̹����� ������ ��� ���� ĵ������ Ȱ��ȭ�Ͽ� ������. 
        // ������ ĵ�������� ������ �̹������� ������ ��쿡�� ó�� ĵ������ �̹������� �ٽ� ������.
        if (CurrentImageIndex == ImagesList.Count - 1)
        {
            CurrentImageIndex = 0;

            if (CurrentCanvasIndex == 0)
            {
                CanvasType1.gameObject.SetActive(false);
                CanvasType2.gameObject.SetActive(true);
                CurrentCanvasIndex = 1;
            }
            else
            {
                CanvasType1.gameObject.SetActive(true);
                CanvasType2.gameObject.SetActive(false);
                CurrentCanvasIndex = 0;
            }
        }
        else
        {
            CurrentImageIndex++;
        }

        // ���� �������� �̹��� ����
        SetCurrentImage();
    }

    private void SetCurrentImage()
    {
        for (int i = 0; i < ImagesList.Count; i++)
        {
            if (i == CurrentImageIndex)
            {
                ImagesList[i].gameObject.SetActive(true);
            }
            else
            {
                ImagesList[i].gameObject.SetActive(false);
            }
        }
    }
}
*/