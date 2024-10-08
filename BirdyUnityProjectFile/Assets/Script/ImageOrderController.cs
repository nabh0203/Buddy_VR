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
        // 각각의 캔버스에 있는 RawImage들을 리스트에 넣음.
        ImagesList.AddRange(CanvasType1.GetComponentsInChildren<RawImage>());
        ImagesList.AddRange(CanvasType2.GetComponentsInChildren<RawImage>());

        // 처음에는 첫 번째 캔버스를 활성화하여 보여줌.
        CanvasType1.gameObject.SetActive(true);
        CanvasType2.gameObject.SetActive(false);

        // 다음 이미지를 보여주는 버튼(NextButton)에 대한 클릭 이벤트를 등록
        NextButton.onClick.AddListener(() =>
        {
            NextImage();
        });
        SetCurrentImage();  
    }

    private void NextImage()
    {
        // 다음 이미지로 넘어가면서, 캔버스가 마지막 이미지를 보여준 경우 다음 캔버스를 활성화하여 보여줌. 
        // 마지막 캔버스에서 마지막 이미지까지 보여준 경우에는 처음 캔버스와 이미지부터 다시 시작함.
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

        // 현재 보여지는 이미지 설정
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