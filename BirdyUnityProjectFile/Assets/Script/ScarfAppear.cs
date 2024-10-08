using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScarfAppear : MonoBehaviour
{
    public GameObject ScarfUp; // 이동할 오브젝트
    public Vector3 destination; // 이동할 위치
    public float moveSpeed; // 이동 속도
    private bool moveScarfUp; // ScarfUp 이동 여부
    /*private bool TActive; //텔포 생김 여부
    private bool EatCherry;
    public GameObject CherryEatable;
    public GameObject Tele1;
    public GameObject Tele2;
    public GameObject Tele3;
    public GameObject ChestUi;*/

    public void OnTriggerStay(Collider other)
    {
        //만약 other이 ChestCollider 태그를 소유하고 있다면,
        if (other.CompareTag("ChestCollider"))
        {
            // 충돌이 감지되면 이동 여부(moveScarfUp)를 true로 변경
            moveScarfUp = true;
        }
        /*//만약 rugcollider라는 태그를 갖고이스면
        if (other.CompareTag("RugCollider"))
        {
            //텔포 active를 true
            TActive = true;
        }*/
        /*if (other.CompareTag("CherryCollider"))
        {
            EatCherry = true;
        }*/
    }

    private void Update()
    {
        // 이동 여부(moveScarfUp)가 true일 경우에
        if (moveScarfUp)
        {
            // ScarfUp(의 위치값을 옮긴다)을 (새로운 위치값Vector3.지정한 방향대로 움직인다 =
            // (scarfup의 포지션을, 지정한 위치값으로, 스피드))destination 위치로 서서히(deltatime) 이동
            ScarfUp.transform.position = Vector3.MoveTowards(ScarfUp.transform.position,
                destination, moveSpeed * Time.deltaTime);
            /*ChestUi.SetActive(true);
            Tele3.SetActive(true);*/
        }
        /*if(TActive)
        {
            Tele1.SetActive(true);
        }
        if (EatCherry)
        {
            CherryEatable.SetActive(false);
            Tele2.SetActive(true);
        }*/
    }

}
