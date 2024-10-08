using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectEnding : MonoBehaviour
{
    public string Window_Ending; // "Item" 태그 아이템이 충돌한 경우 이동할 씬 이름
    public string Cat_Ending; // "Item2" 태그 아이템이 충돌한 경우 이동할 씬 이름
    public string Apple_Ending; // "Item3" 태그 아이템이 충돌한 경우 이동할 씬 이름
    public string Bread_Ending; // "Item4" 태그 아이템이 충돌한 경우 이동할 씬 이름

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Window")) // 충돌한 오브젝트가 "Player" 태그를 가지고 있다면
        {
                Debug.Log("아이템이 있으십니다 이동하겠습니다.");

                // 키 오브젝트가 있는 경우, 다음 씬으로 전환
                SceneManager.LoadScene(Window_Ending);
        }
        else if (other.gameObject.CompareTag("Cat"))
        {
            Debug.Log("아이템이 있으십니다 이동하겠습니다.");

            // 키 오브젝트가 있는 경우, 다음 씬으로 전환
            SceneManager.LoadScene(Cat_Ending);
        }
        else if (other.gameObject.CompareTag("Apple"))
        {
            Debug.Log("아이템이 있으십니다 이동하겠습니다.");

            // 키 오브젝트가 있는 경우, 다음 씬으로 전환
            SceneManager.LoadScene(Apple_Ending);
        }
        else if (other.gameObject.CompareTag("Bread"))
        {
            Debug.Log("아이템이 있으십니다 이동하겠습니다.");

            // 키 오브젝트가 있는 경우, 다음 씬으로 전환
            SceneManager.LoadScene(Bread_Ending);
        }
        else if(other.gameObject.CompareTag("Player"))
        {
            // 키 오브젝트가 없는 경우, 메시지 출력 또는 다른 처리
            Debug.Log("키가 없어서 다음 씬으로 이동할 수 없습니다.");
        }
    }
    
}


