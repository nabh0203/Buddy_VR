using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyRock : MonoBehaviour
{
    public GameObject DisableRock;
    public GameObject TeleportPrefab2;
    public GameObject CorrectSound;
    
    //이 스크립트는 곡괭이로 지정된 게임오브젝트가 포함되어있는 게임오브젝트인 바위와 콜라이드 시 바위가 비활성화 되는 스크립트입니다.
    //곡괭이에게 스크립트를 줍니다.
    //꼭 Rigidbody(Gravity.Disabled)를 각 오브젝트에 넣어야 합니다. ////////
    void OnTriggerEnter(Collider col)
        //게임오브젝트(triggeron)와 콜라이더 col이 충돌 시
    {
        //만약 콜라이더 col이 "block" 태그를 보유한다면
        if (col.gameObject.CompareTag("Block"))
        {
            //DIsableRock 게임오브젝트를 없앤다.
            DisableRock.SetActive(false);
            Instantiate(TeleportPrefab2);
            Instantiate(CorrectSound);
        }
        
    }
}
