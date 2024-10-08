/*using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class UIManager : MonoBehaviour
{
    // ����1 UI�� ������ List.
    // ����1 UI�� ������ ������ List�� �߰���
    public List<GameObject> Type1UIList;
    public GameObject[] uiList; // UI �迭
    // ����2 UI�� ������ ����.
    public GameObject Type2UI;
    private int currentUIIndex = 0; // ���� UI�� �ε���
    // ����1 UI�� �����Ǵ� �ð�
    public float Type1UIDelay = 2f;

    // ����1 UI�� ȭ�鿡 �����Ǵ� �ð�
    public float Type1UIDuration = 4f;

    void Start()
    {
        // ù ��°, �� ��° UI ���� (����1)
        CreateType1UI();
        CreateType1UI();

        // �� ��°, �� ��°, �ټ� ��° UI ���� (����2)
        CreateType2UI();
        CreateType2UI();
        CreateType2UI();
    }

    // ����1 UI ���� �Լ�
    void CreateType1UI()
    {
        // �� ������Ʈ ����
        GameObject newUI = new GameObject("Type1UI");

        // Image ������Ʈ �߰�
        Image image = newUI.AddComponent<Image>();

        // �̹��� ���� ����
        image.color = Color.red;

        // Canvas �׷� ������Ʈ �߰� �� �Ӽ� ����
        CanvasGroup canvasGroup = newUI.AddComponent<CanvasGroup>();
        canvasGroup.alpha = 0f;                     // ó������ ����
        canvasGroup.interactable = false;           // ��ȣ �ۿ� �Ұ����ϵ��� ����
        canvasGroup.blocksRaycasts = false;         // ���콺 Ŭ���� �����ϵ��� ����

        // ������ UI ������Ʈ�� List�� �߰�
        Type1UIList.Add(newUI);

        // 2�� �Ŀ� ���� �� ����
        Invoke("ActivateType1UI", Type1UIDelay);
    }

    // ����1 UI ���� �� 2�� �Ŀ� ���� ���� �����ϴ� �Լ�
    void ActivateType1UI()
    {
        foreach (GameObject ui in Type1UIList)
        {
            // CanvasGroup ������Ʈ ��������
            CanvasGroup canvasGroup = ui.GetComponent<CanvasGroup>();

            // ���� �� ����
            canvasGroup.alpha = 1f;

            // ���� �ð� �Ŀ� ��Ȱ��ȭ�ϱ�
            Invoke("DeactivateType1UI", Type1UIDuration);
        }
    }

    // ����1 UI ��Ȱ��ȭ �Լ�
    void DeactivateType1UI()
    {
        foreach (GameObject ui in Type1UIList)
        {
            // CanvasGroup ������Ʈ ��������
            CanvasGroup canvasGroup = ui.GetComponent<CanvasGroup>();

            // ���� ���� 0���� ����
            canvasGroup.alpha = 0f;

            // ��ȣ�ۿ� �Ұ����ϵ��� ����
            canvasGroup.interactable = false;

            // ���콺 Ŭ�� �����ϵ��� ����
            canvasGroup.blocksRaycasts = false;
        }
    }

    void CreateType2UI()
    {
        // �� ������Ʈ ����
        GameObject newUI = new GameObject("Type2UI");

        // Image ������Ʈ �߰�
        Image image = newUI.AddComponent<Image>();

        // �̹��� ���� ����
        image.color = Color.blue;

        // Canvas �׷� ������Ʈ �߰�
        CanvasGroup canvasGroup = newUI.AddComponent<CanvasGroup>();

        // Button ������Ʈ �߰�
        Button button = newUI.AddComponent<Button>();

        // ��ư�� ������ �� ȣ���� �Լ� ���
        button.onClick.AddListener(DeactivateType2UI);

        // ������ UI�� ��Ȱ��ȭ
        canvasGroup.alpha = 0f;
        canvasGroup.interactable = false;
        canvasGroup.blocksRaycasts = false;

        // ������ UI�� ������ ����
        Type2UI = newUI;

        // 2�� �Ŀ� UI Ȱ��ȭ
        Invoke("ActivateType2UI", Type1UIDelay);
    }

    // ����2 UI Ȱ��ȭ �Լ�
    void ActivateType2UI()
    {
        // CanvasGroup ������Ʈ ��������
        CanvasGroup canvasGroup = Type2UI.GetComponent<CanvasGroup>();

        // ���� �� ����
        canvasGroup.alpha = 1f;

        // ��ȣ �ۿ� �����ϵ��� ����
        canvasGroup.interactable = true;

        // ���콺 Ŭ�� ó�� �����ϵ��� ����
        canvasGroup.blocksRaycasts = true;
    }

    // ����2 UI ��Ȱ��ȭ �Լ�
    void DeactivateType2UI()
    {
        // CanvasGroup ������Ʈ ��������
        CanvasGroup canvasGroup = Type2UI.GetComponent<CanvasGroup>();

        // ���� ���� 0���� ����
        canvasGroup.alpha = 0f;

        // ��ȣ�ۿ� �Ұ����ϵ��� ����
        canvasGroup.interactable = false;

        // ���콺 Ŭ�� �����ϵ��� ����
        canvasGroup.blocksRaycasts = false;
    }
}
*/