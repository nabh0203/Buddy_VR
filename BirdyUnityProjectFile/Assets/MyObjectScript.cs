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

    //이 밑으로 선택적. 다른 스크립트로부터 호출되는 public 메소드를 정의함으로써 다른 GameObject에서 인스턴스화 된 객체의 동작을 제어합니다.
}

