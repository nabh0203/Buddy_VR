Buddy_VR
=============


![Group 133](https://github.com/user-attachments/assets/d86012f8-cd1f-4bc7-bfd7-cb6b00a30cdd)

## **사용 기술**

- Unity
- C#
- XR Interaction ToolKit
- VR

## **버디? Vector?**
![Group 27126](https://github.com/user-attachments/assets/34d3fe04-af34-4b45-b925-e76e08585a7b)

> **진로의 “ 방향성( Vector ) ”을 잡게 해준 콘텐츠**
> 
> 조류는 벌레를 사냥하고, 식물의 번식을 돕는 등 생태계의 큰 역할을 하고 있습니다.
> 
> 그리하여 조류 생태계의 심각성 공감과 환경 보호 문제에 대한 경각심을 일으키기 위해  **“ 방향성 ”** 을 조류 보호로 잡고
> 
> VR 게임 콘텐츠를 제작하였으며  제가 하고싶은 진로의 **“ 방향성 ”** 을 잡게 해준 콘텐츠입니다.

---

## **게임 엔딩 구현**
![Birdy___](https://github.com/user-attachments/assets/ef0f70fe-dc49-4345-9655-9bb88ec95983)
![Birdy___1](https://github.com/user-attachments/assets/abf32048-f205-43ef-8a23-06a1c137c670)

> **사용자는 4가지의 엔딩 중 한 가지를 볼 수 있습니다.**
> 
> 사용자가 게임을 다 진행하고 나온 **4가지 오브젝트** 중 **하나의 오브젝트**를 가지고
>
> 엔딩에 돌입하면 사용자가 소지한 **오브젝트에 따른 엔딩 결과**를 볼 수 있습니다.

---

## **개발 과정**
![image 36](https://github.com/user-attachments/assets/cab67717-b2a4-4b7a-be09-12d449b4e852)
![image 37](https://github.com/user-attachments/assets/47d076d8-ecb6-49c2-bde5-0e6b78011c59)

> **컨트롤러 설정 / XR Interaction Toolkit**
>
> 컨트롤러 기능을 설정하는데 있어서 제일로 중요하게 생각했던 부분은
> 
> **"처음 VR을 접해보는 사용자들도 어려움 없이 조작할 수 있어야 한다.”** 라는 결론이 도출되게 되었습니다.
> 
> 그렇기 때문에 여러 조작법 중 제일 조작이 쉬운  **" XR Interaction Toolkit 의 텔레포트 기능 "** 을 사용하여
> 
> **사용자 방향성(Vector)** 에 맞추어 제작하게 되었습니다.

### **VR Fade**

> **Fade** 효과를 사용하고자 **OVR Intergration** 안에 있는 예제를 활용해봤으나 계속
> 
> 오류가 생겨 자체적으로 **OVR Intergration** 없이 **Fade 효과를** 사용할 수 있게 자체적으로 제작하였습니다.




### **Tag Plus**

> 사용자는 **4개의 오브젝트**중 **하나**를 선택하여 **한 가지의 엔딩**을
> 
> 볼 수 있는 로직을 구현하기 위하여 **Player** 오브젝트의 자식 오브젝트인 **Item** 오브젝트의 **Tag**를
> 
> 바꿔 **엔딩**을 체험할 수 있게 제작하였습니다.

### ObjectEnding

```csharp
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

```

<aside>
<img src="/icons/snippet_gray.svg" alt="/icons/snippet_gray.svg" width="40px" /> **ObjectEnding 스크립트 제작중 중점 사항**

> **Tag Plus** 스크립트와 같이 사용되는 엔딩 스크립트 입니다.
**지정된 태그**와 일치하는 엔딩 **Scene** 으로 이동할 수 있게 제작한 스크립트 입니다.
> 
</aside>

### SetActive

```csharp
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

```

<aside>
<img src="/icons/snippet_gray.svg" alt="/icons/snippet_gray.svg" width="40px" /> **SetActive 스크립트 제작중 중점 사항**

> 초기 게임 기획 단계에서, 사용자는 게임을 클리어함으로써 **네 가지 오브젝트**를 
획득할 수 있는 방식을 고려했습니다.
그러나 테스트 과정에서 게임 클리어 시점에 모든 **네 오브젝트**를 동시에 획득하는 것이 불가능하다는 것을 발견했습니다. 
이에 대한 해결책으로,해당 스크립트를 도입해 게임을 성공적으로 마친 후
엔딩을 감상하기 직전의 마지막 단계에서 **네 개의 오브젝트**가 나타나도록 
구현했습니다.
> 
> 
> 플레이어는 이 중에서 **하나의 오브젝트**를 선택, 그 선택에 따라 다양한 엔딩을 경험할 수 있게 만들었습니다. 
> 
> 이러한 접근 방식은 게임의 **재미**와 **선택의 중요성**을 동시에 강조합니다.
> 
</aside>

### OpenBoxScript

```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBoxScript : MonoBehaviour
{
    public GameObject VRBox;
    public GameObject Rock;
    public GameObject Rock1;
    public GameObject UnRock;
    public GameObject UnRock1;
    public GameObject Key;
    public GameObject Box;
    public GameObject Sound;
    public GameObject InCorrectSound;
    public GameObject NextTeleport;
    public GameObject Key1;
    public GameObject Key2;
    public GameObject Key3;
    public GameObject Key4;
    public GameObject KeyEffect1;
    public GameObject KeyEffect2;
    public GameObject KeyEffect3;
    public GameObject KeyEffect4;
    public GameObject KeyAreaEffect1;

    private void Start()
    {
        VRBox.gameObject.SetActive(false);
        UnRock.gameObject.SetActive(false);
        UnRock1.gameObject.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        // Player 태그를 가진 오브젝트가 트리거 되면 
        if (other.CompareTag("Key"))
        {
            Box.gameObject.AddComponent<BoxCollider>();

            // 추가된 콜라이더 설정
            /*BoxCollider boxCollider = Box.gameObject.GetComponent<BoxCollider>();
            boxCollider.isTrigger = true;
            boxCollider.size = new Vector3(2, 2, 2);*/
            Rock.gameObject.SetActive(false);
            Rock1.gameObject.SetActive(false);
            VRBox.gameObject.SetActive(true);
            UnRock.gameObject.SetActive(true);
            UnRock1.gameObject.SetActive(true);
            Key.gameObject.SetActive(false);
            NextTeleport.gameObject.SetActive(true);
            Box.gameObject.SetActive(false);
            Instantiate(Sound);
            Key1.gameObject.SetActive(false);
            Key2.gameObject.SetActive(false);
            Key3.gameObject.SetActive(false);
            Key4.gameObject.SetActive(false);
            KeyEffect1.gameObject.SetActive(false);
            KeyEffect2.gameObject.SetActive(false);
            KeyEffect3.gameObject.SetActive(false);
            KeyEffect4.gameObject.SetActive(false);
            KeyAreaEffect1.gameObject.SetActive(false);

        }
        else if (other.CompareTag("WrongKey"))
            {
                Instantiate(InCorrectSound);
            }
    }
}

```

### AppleFall

```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleFall : MonoBehaviour
{
    public GameObject apple;
    public GameObject stick;
    public GameObject CorrectSound;
    public GameObject AppleEffect;
    public GameObject AppleEffect2;

    Rigidbody rigidbody2;
    void Start()
    {
        AppleEffect2.SetActive(false);
        rigidbody2 = apple.GetComponent<Rigidbody>();
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == stick && rigidbody2 != null)
        {
                rigidbody2.useGravity = true;
                Instantiate(CorrectSound);
                AppleEffect.SetActive(false);
                AppleEffect2.SetActive(true);
        }
    }
    
}

```

<aside>
🎮 **게임 관련 스크립트 제작중 중점 사항**

> 4가지의 게임중 **“상자 열기 게임”**,**”사과 떨어뜨리기 게임”** 의 스크립트 입니다.
초기에 **“상자 열기 게임”**,**”사과 떨어뜨리기 게임”** 의 스크립트들을 제작한 뒤
후 에 등장하는 **“수풀에서 오브젝트 찾기 게임”**,**”쓰레기통에 쓰레기 넣기 게임”** 들은
****스크립트를 작성하는데 참고하여 제작하였습니다.
주로 **OnTriggerEnter()** 와 **SetActive()** 함수를 사용하여 제작하였습니다.
> 
</aside>

## $\large\bf{FeedBack}$

> 이 프로젝트를 진행하면서 처음 경험한 것들이 정말 많았습니다.
> 
> 
> 우선, 혼자가 아니라 팀원들과 협력하여 진행한 프로젝트였습니다. 
> 
> Unity라는 프로그램을 통해 첫 VR 작품을 만들 수 있었던 점도 큰 의미가 있었습니다. 
> 
> 더불어, 팀원들과 함께 협업하여 공모전에 출품해 첫 수상을 경험했으며, 
> 그 후에도 여러 행사와 부스에서 작품을 전시할 기회가 있었습니다.
> 
> 하지만, 이 프로젝트에 대한 아쉬움도 많았습니다.
> 
> 이 작품은 제가 처음으로 만든 VR 작품이었고, 당시 저와 팀원들 모두 VR에 대한 지식이 
> 부족했습니다.
> 많은 노력을 기울였지만, 그럼에도 불구하고 작품의 퀄리티나 전체적인 방향성에 대한 
> 아쉬움이 크게 남았습니다.
> 

![COSS 글로벌 피칭&창업 경진대회 부스](https://prod-files-secure.s3.us-west-2.amazonaws.com/9f4f04d2-e3d9-4279-8c92-dec2e691c5e0/78773c9a-7274-453a-ae54-7b9eda6263db/buddy1.png)

COSS 글로벌 피칭&창업 경진대회 부스

![COSS 글로벌 피칭&창업 경진대회 부스](https://prod-files-secure.s3.us-west-2.amazonaws.com/9f4f04d2-e3d9-4279-8c92-dec2e691c5e0/398d96e7-b367-4d83-9b8f-1e11fb83834a/buddy2.png)

COSS 글로벌 피칭&창업 경진대회 부스

![부산국제마케팅광고제 참가 및 홍보 부스](https://prod-files-secure.s3.us-west-2.amazonaws.com/9f4f04d2-e3d9-4279-8c92-dec2e691c5e0/bbf0af03-b023-4f34-a93a-3ddd4cdfaa92/buddy3.png)

부산국제마케팅광고제 참가 및 홍보 부스

![부산국제마케팅광고제 참가 및 홍보 부스](https://prod-files-secure.s3.us-west-2.amazonaws.com/9f4f04d2-e3d9-4279-8c92-dec2e691c5e0/cf4ed483-c4b4-422b-815c-f416ca06c092/buddy4.png)

부산국제마케팅광고제 참가 및 홍보 부스

## $\large\bf{End}$

![Group 27126.png](https://prod-files-secure.s3.us-west-2.amazonaws.com/9f4f04d2-e3d9-4279-8c92-dec2e691c5e0/536f4a18-238f-4612-824e-62571af47dc8/Group_27126.png)

<aside>
🔚 **버디** 그리고 **방향성(Vector)**

이 프로젝트는 제게 **VR**에 대한 깊은 지식을 습득하고, **VR** 개발이라는 진로 ***“방향성”*** 을 
확실히 잡는 데 큰 도움을 준 중요한 계기였습니다. 

**VR** 개발에 대한 열정은 있었지만, 구체적인 ***“방향성”*** 을 설정하는 데 있어서 많은 고민이 있었습니다. 

이 프로젝트를 통해 실제 **VR** 콘텐츠를 제작하며 **VR** 기술에 대한 **이해**를 넓히고, 
**’제 꿈을 실현 가능하다.’** 라는 것을 확인할 수 있었습니다.

또한, 이 프로젝트를 통해 처음으로 공모전에 참가하여 수상하는 영광을 얻었습니다. 

이 성취는 제 노력과 **VR** 개발에 대한 열정이 인정받았다는 의미이며, 앞으로 **VR** 개발자로서 자신감을 갖고 나아갈 수 있는 ***“방향성”*** 을 심어주었습니다.

이 프로젝트를 통해 얻은 경험과 지식은 제 **VR** 개발의 꿈을 향해 더욱 확신을 갖고 
나아갈 수 있는 튼튼한 기반을 마련해주었습니다.

</aside>
2023 국제 커뮤니케이션 공모전 출품작 및 우수상 수상 "Buddy"
