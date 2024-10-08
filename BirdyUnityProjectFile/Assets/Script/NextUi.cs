using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextUi : MonoBehaviour
{




    public GameObject[] uiList; // UI �迭
    public float displayTime = 4f; // UI�� ȭ�鿡 �����Ǵ� �ð�

    private int currentUIIndex = 0; // ���� UI�� �ε���
    private float displayTimer = 0f; // UI�� ȭ�鿡 �����Ǵ� �ð��� ��� Ÿ�̸�

    private void Update()
    {
        // ���� UI�� Ȱ��ȭ �� ���
        if (uiList[currentUIIndex].activeSelf)
        {
            displayTimer += Time.deltaTime;

            // ���� UI�� displayTime (4��)�� ���� ���
            if (displayTimer >= displayTime)
            {
                uiList[currentUIIndex].SetActive(false); // ���� UI�� ��Ȱ��ȭ�ϰ�
                displayTimer = 0f; // Ÿ�̸� �ʱ�ȭ

                currentUIIndex++; // ���� UI�� �̵�
                if (currentUIIndex >= uiList.Length) // ������ UI���� ��� ����ߴٸ�
                {
                    currentUIIndex = 0; // ù ��° UI�� �̵�
                }

                uiList[currentUIIndex].SetActive(true); // ���� UI Ȱ��ȭ
            }
        }
    }
}
