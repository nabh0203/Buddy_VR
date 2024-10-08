using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class On_Click_BackButton : MonoBehaviour
{
    public GameObject originalCanvas;
    // Start is called before the first frame update
    // 백 버튼이 클릭되었을 때 호출될 함수
    public void OnBackButtonClick()
    {
        // 원래 캔버스를 활성화하여 보임
        originalCanvas.SetActive(true);
        // 현재 캔버스를 비활성화하여 숨김
        gameObject.transform.parent.gameObject.SetActive(false);
    }
}
