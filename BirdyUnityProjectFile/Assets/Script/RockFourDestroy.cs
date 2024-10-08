using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockFourDestroy : MonoBehaviour
{
    //이 스크립트는 4번 부딫힐 시 특정 게임오브젝트가 삭제됩니다.
    public GameObject rock; //삭제되는 것
    public GameObject RockSound;//부딫힐 때마다 나는 사운드
    public GameObject ClearSound; //클리어 시 사운드
    private int triggerCount = 0; //트리거 된 카운트 실수형 선언 = 0

    private void OnTriggerEnter(Collider other)
    {
        //만약 콜라이더 other이 block라는 태그를 소유하고 있는 아이가 트리거 될 시,
        if (other.gameObject.CompareTag("Block"))
        {
            
            //트리거된 카운트가 1씩 증가한다
            triggerCount++;
            //카운트가 로그로 보여진다
            Debug.Log("Count:" + triggerCount);

            //만약 4번째로 카운트가 도달하면,
            if (triggerCount >= 4)
            {
                //없어질 게임오브젝트가 없어진다.
                rock.SetActive(false);
                //게임 클리어 시 사운드가 복제된다(실행된다)
                Instantiate(ClearSound);
                //로그창이 뜬다.
                Debug.Log("Destroyed");
            }
            else //카운트가 4 이상이 아닐 시, 트리거 당할 시 항상
            {
                //바위 상호작용 사운드가 들린다.
                Instantiate(RockSound);
            }
        }
    }
}
