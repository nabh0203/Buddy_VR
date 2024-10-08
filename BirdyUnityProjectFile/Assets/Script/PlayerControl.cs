using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{
    public GameObject target; // 플레이어에게 상속될 타겟 오브젝트
    public Button[] buttons; // 버튼을 저장할 배열 변수

    public void InheritToPlayer()
    {
        target.transform.parent = GameObject.FindGameObjectWithTag("Player").transform; // 타겟 오브젝트를 플레이어의 자식 오브젝트로 만듭니다.
        target.transform.localPosition = Vector3.zero; // 타겟 오브젝트의 로컬 위치를 (0, 0, 0)으로 설정합니다.
        target.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f); // 타겟 오브젝트의 스케일을 (0.5, 0.5, 0.5)으로 설정합니다.
        foreach (Transform child in transform)
        {
            Button[] childButtons = child.GetComponentsInChildren<Button>();
            foreach (Button button in childButtons)
            {
                button.gameObject.SetActive(false);
            }
        }
    }
}
