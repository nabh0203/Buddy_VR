using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextUi : MonoBehaviour
{




    public GameObject[] uiList; // UI 배열
    public float displayTime = 4f; // UI가 화면에 유지되는 시간

    private int currentUIIndex = 0; // 현재 UI의 인덱스
    private float displayTimer = 0f; // UI가 화면에 유지되는 시간을 재는 타이머

    private void Update()
    {
        // 현재 UI가 활성화 된 경우
        if (uiList[currentUIIndex].activeSelf)
        {
            displayTimer += Time.deltaTime;

            // 현재 UI가 displayTime (4초)이 지난 경우
            if (displayTimer >= displayTime)
            {
                uiList[currentUIIndex].SetActive(false); // 현재 UI를 비활성화하고
                displayTimer = 0f; // 타이머 초기화

                currentUIIndex++; // 다음 UI로 이동
                if (currentUIIndex >= uiList.Length) // 마지막 UI까지 모두 출력했다면
                {
                    currentUIIndex = 0; // 첫 번째 UI로 이동
                }

                uiList[currentUIIndex].SetActive(true); // 다음 UI 활성화
            }
        }
    }
}
