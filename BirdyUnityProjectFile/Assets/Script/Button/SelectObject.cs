using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class SelectObject : MonoBehaviour
{
    public string buttonTag; // 버튼 태그
    public GameObject button2;  //오브젝트 상속시 또다른 오브젝트를 주울시 나타나는 텍스트 
    public GameObject Pannel; // 플레이어에게 보여지는 판넬 오브젝트
    public GameObject target; // 플레이어에게 상속될 타겟 오브젝트
    public GameObject target2; // 플레이어에게 보여지는 타겟 오브젝트
    

    private Button[] buttons; // 버튼을 저장할 배열 변수

    private void Start()
    {
        button2.gameObject.SetActive(false); //텍스트 비활성화
        buttons = GameObject.FindGameObjectsWithTag(buttonTag)
                           .Select(go => go.GetComponent<Button>())
                           .ToArray(); // 버튼 배열 초기화
        foreach (Button button in buttons)
        {
            button.gameObject.SetActive(false); // 버튼 비활성화
            Pannel.gameObject.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // 플레이어와 충돌했을 때
        {
            foreach (Button button in buttons)
            {
                if (!button.gameObject.activeSelf) // 버튼이 비활성화된 경우에만 활성화합니다.
                {
                    button.gameObject.SetActive(true); // 버튼 활성화
                    Pannel.gameObject.SetActive(true);
                }
            }
        }
    }
    public void InheritToPlayer()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        bool hasOtherTags = false;

        // 플레이어가 이미 다른 태그를 가진 오브젝트를 상속 받고 있는지 확인합니다.
        foreach (Transform child in player.transform)
        {
            if (child.CompareTag("Window") || child.CompareTag("Cat") || child.CompareTag("Apple") || child.CompareTag("Bread"))
            {
                hasOtherTags = true;
                break;
            }
        }

        // 다른 태그를 가진 오브젝트를 상속 받고 있는 경우
        if (hasOtherTags)
        {
            Debug.Log("이미 다른 태그를 가진 오브젝트를 상속 받고 있습니다.");
            foreach (Button button in buttons)
            {
                button.gameObject.SetActive(false); // 버튼 비활성화
            }
            button2.gameObject.SetActive(true); //텍스트 활성화
            Pannel.gameObject.SetActive(true); //판넬 활성화
            return;
        }

        // 플레이어에게 상속합니다.
        target.transform.parent = player.transform;
        target.transform.localPosition = Vector3.zero;
        target.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);

        // 버튼을 비활성화합니다.
        foreach (Button button in buttons)
        {
            button.gameObject.SetActive(false);
            Pannel.gameObject.SetActive(false);
        }

        // SelectObject 스크립트를 비활성화합니다.
        target.SetActive(true);
        target2.SetActive(false);
    }



    public void OnButtonClick()
    {
        foreach (Button button in buttons)
        {
            button.gameObject.SetActive(false); // 버튼 비활성화
            Pannel.gameObject.SetActive(false); // 판넬 비활성화
        }
    }
    public void OnOtherButtonClick(Button otherButton)
    {
        OnButtonClick();

        otherButton.gameObject.SetActive(false);
        button2.gameObject.SetActive(false);
        Pannel.gameObject.SetActive(false);
    }
}
