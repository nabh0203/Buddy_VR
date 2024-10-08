using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActive : MonoBehaviour
{
    public GameObject Item;
    public GameObject Item2;
    // Start is called before the first frame update
    void Start()
    {
        // 게임클리어시 나타나는 오브젝트
        Item.gameObject.SetActive(true);
        //엔딩 자리에 있는 오브젝트
        Item2.gameObject.SetActive(false); 
    }

    // Update is called once per frame
    //트리거 됐을시에
    void OnTriggerEnter(Collider other)
    {
        // Player 태그를 가진 오브젝트가 트리거 되면 
        if (other.CompareTag("Player"))
        {
            // 게임클리어시 있는 오브젝트 비활성화
            Item.gameObject.SetActive(false);
            // 엔딩 자리에 있는 오브젝트 활성화
            Item2.gameObject.SetActive(true);
        }
    }
}
