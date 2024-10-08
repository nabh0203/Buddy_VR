using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class On_Click_OptionButton : MonoBehaviour
{
    // 이동할 다른 캔버스 오브젝트를 연결할 변수
    public GameObject targetCanvas;
    // 이전에 활성화되어 있던 캔버스 오브젝트를 연결할 변수
    public GameObject previousCanvas;

    // 버튼이 클릭되었을 때 호출될 함수
    public void OnButtonClick()
    {
        // 현재 캔버스를 비활성화하여 숨김
        gameObject.transform.parent.gameObject.SetActive(false);
        // 이동할 캔버스를 활성화하여 보임
        targetCanvas.SetActive(true);

    }

    // 백 버튼이 클릭되었을 때 호출될 함수
    public void OnBackButtonClick()
    {
        // 이전에 활성화되어 있던 캔버스를 활성화하여 보임
        previousCanvas.SetActive(true);
        // 현재 캔버스를 비활성화하여 숨김
        gameObject.SetActive(false);
    }


} 

