using UnityEngine;

public class ObjectSelector4 : MonoBehaviour
{
    public string playerTag = "Player"; // �÷��̾� �±�
    public GameObject[] objectsToSelect; // ������ ������Ʈ��
    public Transform[] startingPositions; // ������Ʈ���� ���� ��ġ��
    public Camera mainCamera; // ���� ī�޶�
    public GameObject[] buttons; // ��ư���� ������ �迭

    private GameObject selectedObject; // ���õ� ������Ʈ
    private bool isItemSelected = true; // �������� ���õǾ����� ����
    private Vector3 originalObjectPosition; // ������Ʈ�� ���� ��ġ
    private Quaternion originalObjectRotation; // ������Ʈ�� ���� ȸ����

    void Start()
    {
        // ���� ī�޶� ã�� Ȱ��ȭ
        Camera.main.enabled = true;

        // ������Ʈ���� ���� ��ġ�� ȸ���� ����
        for (int i = 0; i < objectsToSelect.Length; i++)
        {
            originalObjectPosition = objectsToSelect[i].transform.position;
            originalObjectRotation = objectsToSelect[i].transform.rotation;
        }

        // ��ư ��Ȱ��ȭ
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].SetActive(false);
        }
    }

    void Awake()
    {
        // mainCamera ������ ���� Scene���� "Main Camera" �±׸� ���� ī�޶� ã�� �Ҵ�
        mainCamera = Camera.main;
    }

    void Update()
    {
        // ���õ� ������Ʈ�� ���� ���
        if (!isItemSelected)
        {
            // �÷��̾��� ��ġ�� ���� ������ ������Ʈ���� ��ġ ������ �Ÿ��� ����Ͽ� ���� ����� ������Ʈ�� ����
            float shortestDistance = Mathf.Infinity;
            GameObject nearestObject = null;

            foreach (GameObject obj in objectsToSelect)
            {
                float distanceToPlayer = Vector3.Distance(obj.transform.position,
                                                           GameObject.FindGameObjectWithTag(playerTag).transform.position);
                if (distanceToPlayer < shortestDistance)
                {
                    shortestDistance = distanceToPlayer;
                    nearestObject = obj;
                }
            }

            // �÷��̾ ���� �Ÿ� ���� �ְ� ���� ������ ������Ʈ�� �ִ� ���
            if (nearestObject != null && shortestDistance <= 0.3f)
            {
                // ��ư Ȱ��ȭ
                for (int i = 0; i < buttons.Length; i++)
                {
                    buttons[i].SetActive(true);
                }

                // ���� ������ ������Ʈ�� selectedObject ������ ����
                selectedObject = nearestObject;
            }
            else
            {
                // ��ư ��Ȱ��ȭ
                for (int i = 0; i < buttons.Length; i++)
                {
                    buttons[i].SetActive(false);
                }

                // selectedObject ���� �ʱ�ȭ
                selectedObject = null;
            }
        }
    }

        // ������ ���� ��� �� ȣ��Ǵ� �Լ�
        public void CancelSelection()
    {
        if (selectedObject != null && isItemSelected)
        {
            // ���õ� ������Ʈ�� ���� ��ġ�� ȸ�������� �ǵ���
            selectedObject.transform.parent = null;
            selectedObject.transform.position = originalObjectPosition;
            selectedObject.transform.rotation = originalObjectRotation;

            // ������ ���� ���� �ʱ�ȭ
            selectedObject = null;
            isItemSelected = false;

        }
    }
}
