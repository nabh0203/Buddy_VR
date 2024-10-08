using UnityEngine;
using UnityEngine.UI;

public class Test5 : MonoBehaviour
{
    public GameObject[] items; // 아이템 오브제의 GameObject 배열
    public Button[] buttons; // 버튼을 참조할 변수 배열
    public string otherTag = "Block";

    private void Start()
    {
        // 버튼 비활성화
        foreach (Button button in buttons)
        {
            button.gameObject.SetActive(false);
        }
    }

    // 버튼을 선택했을 때 호출되는 함수
    public void OnButtonClick()
    {
        // 아이템 오브젝트를 플레이어의 자식 오브젝트로 설정하고 비활성화
        foreach (GameObject item in items)
        {
            item.transform.SetParent(transform);
            item.GetComponent<Renderer>().enabled = false;
        }

        GameObject[] otherObjects = GameObject.FindGameObjectsWithTag(otherTag);
        foreach (GameObject obj in otherObjects)
        {
            Destroy(obj);
        }
        foreach (Button button in buttons)
        {
            button.gameObject.SetActive(false);
        }  
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Item"))
        {
                // 버튼 활성화
                foreach (Button button in buttons)
                {
                    button.gameObject.SetActive(true);
                }
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        foreach (GameObject item in items)
        {
            item.GetComponent<Renderer>().enabled = true;
        }
    }
}
