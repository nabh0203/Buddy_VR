using UnityEngine;
using UnityEngine.UI;

public class Button_Select : MonoBehaviour
{
    public GameObject objectToInherit; // 상속받을 오브젝트를 Inspector 창에서 할당
    public GameObject parentObject; // 상속할 부모 오브젝트를 Inspector 창에서 할당

    private void Start()
    {
        // 버튼 클릭 이벤트에 메서드 등록
        Button button = GetComponent<Button>();
        button.onClick.AddListener(InheritObject);
    }

    public void InheritObject()
    {
        // 버튼이 클릭되면 objectToInherit를 parentObject의 자식 오브젝트로 추가
        objectToInherit.transform.SetParent(parentObject.transform, true);
        objectToInherit.SetActive(false); // 추가된 오브젝트를 비활성화
    }
}


