using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyObjectScript : MonoBehaviour
{
    public static List<GameObject> allInstances = new List<GameObject>();

    private void Awake()
    {
        allInstances.Add(gameObject);
    }

    private void OnDestroy()
    {
        allInstances.Remove(gameObject);
    }

    public static void SetActiveAll(bool isActive)
    {
        foreach (GameObject obj in allInstances)
        {
            obj.SetActive(isActive);
        }
    }

    //�� ������ ������. �ٸ� ��ũ��Ʈ�κ��� ȣ��Ǵ� public �޼ҵ带 ���������ν� �ٸ� GameObject���� �ν��Ͻ�ȭ �� ��ü�� ������ �����մϴ�.
}

