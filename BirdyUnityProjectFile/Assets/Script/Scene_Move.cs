using UnityEngine;
using UnityEngine.SceneManagement;




public class Scene_Move : MonoBehaviour
{
    
    // Start is called before the first frame update
    public void NextSceneWithString()
    {
        // 문자열 이용해서 씬 전환
        //SceneManager.LoadScene("Stage1");        // OK
        SceneManager.LoadScene("Scene/SampleScene");
    }

    // Update is called once per frame
    public void NextSceneWithNum()
    {
        // 씬 번호를 이용해서 씬 이동
        SceneManager.LoadScene(1);  // 0 번째 씬 로드
    }
}