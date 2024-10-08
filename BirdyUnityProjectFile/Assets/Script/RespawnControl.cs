using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnControl : MonoBehaviour
{

    private Vector3 startingPosition;
    public GameObject RespawnSoundPrefab;

    void Start()
    {
        startingPosition = transform.position;
    }

    void OnTriggerEnter(Collider other)
    {
        // 충돌한 오브젝트가 플레이어인 경우
        if (other.CompareTag("Trash"))
        {
            // 플레이어를 리스폰 포인트로 위치 이동
            gameObject.transform.position = startingPosition;
            Instantiate(RespawnSoundPrefab);

        }
    }


}



