using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashCan : MonoBehaviour
    //스크립트 설명 :
    //이 스크립트에서는 object1Triggered와 object2Triggered 두 개의 boolean 플래그 변수를 사용하여
    //Object1과 Object2가 씬에서 충돌체에 충돌하였는지 여부를 추적합니다.
    //충돌체가 Object1 또는 Object2와 충돌하면 object1Triggered 또는 object2Triggered를 true로 설정합니다.
    //CheckObjectsTriggered() 메소드에서는 object1Triggered와 object2Triggered가 모두 true로 설정되었는지를 확인하여,
    //그렇다면 "Clear!"를 콘솔에 출력합니다.이 메소드는 OnTriggerEnter() 메소드에서 호출됩니다.
    //이 스크립트를 사용하여 원하는 대상에 충돌하면 "Clear!"가 출력되도록 할 수 있습니다.
{
    public GameObject DonutPrefab;
    public GameObject Object1; // 첫 번째 게임 오브젝트, 이것과 충돌 검사를 할 대상
    public GameObject Object2; // 두 번째 게임 오브젝트, 이것과 충돌 검사를 할 대상
    public GameObject Object3; // 세 번째 게임 오브젝트, 이것과 충돌 검사를 할 대상
    public GameObject UIPrefab; //클리어 후 뜨는 UI 프리팹
    public GameObject TeleportPrefab; //클리어 후 뜨는 텔레포트 프리팹
    public GameObject CorrectSoundPrefab;
    public GameObject ClearSoundPrefab;
    public GameObject AreaEffectPrefab;
    private bool object1Triggered; // Object1이 충돌체에 충돌하였는지 여부를 저장하는 플래그 변수
    private bool object2Triggered; // Object2이 충돌체에 충돌하였는지 여부를 저장하는 플래그 변수
    private bool object3Triggered; // Object3이 충돌체에 충돌하였는지 여부를 저장하는 플래그 변수
    
    

    
    private void OnTriggerEnter(Collider other)
    {
        
        
        // 충돌한 게임 오브젝트가 Object1인지 검사
        if (other.gameObject == Object1)
        {
            object1Triggered = true;
            Instantiate(CorrectSoundPrefab);
        }
        // 충돌한 게임 오브젝트가 Object2인지 검사
        if (other.gameObject == Object2)
        {
            object2Triggered = true;
            Instantiate(CorrectSoundPrefab);
        }
        if (other.gameObject == Object3)
        {
            object3Triggered = true;
            Instantiate(CorrectSoundPrefab);
        }
        //Object1과 Object2 두 개의 객체가 트리거에 충돌되었는지를 검사하고, 트리거 됐을 시 기능을 실행할 수 있도록
        //OnTriggerEnter에 입력하여 boolean이 제대로 작동하면 코드가 작동할 수 있도록 한다. 햇갈리면 ChatGpt사용해.
        CheckObjectsTriggered();
    }

    private void CheckObjectsTriggered()
    {
        // Object1과 Object2 모두 충돌체에 충돌하였다면 "Clear!"를 콘솔에 출력
        if (object1Triggered && object2Triggered&&object3Triggered)
        {
            Debug.Log("Clear!");
            DonutPrefab.SetActive(true);
            AreaEffectPrefab.SetActive(false);
            Instantiate(UIPrefab);
            Instantiate(TeleportPrefab);
            Instantiate(ClearSoundPrefab);
        }
        
    }
}
