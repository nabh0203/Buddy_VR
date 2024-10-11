Buddy_VR
=============


![Group 133](https://github.com/user-attachments/assets/d86012f8-cd1f-4bc7-bfd7-cb6b00a30cdd)

**사용 기술**

- Unity
- C#
- XR Interaction ToolKit
- VR

**경력 사항**

- COSS 글로벌 피칭&창업 경진대회 참여
- 계원 산학협력 EXPO 부스 전시
- 커뮤니케이션국제디자인공모전 우수작
- 부산국제마케팅광고제 참가 및 홍보
- K-Global@Vietnam 참가 

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

---
### **1. VR Fade**
![BirdyFade](https://github.com/user-attachments/assets/d58d67e4-35c5-4ce4-8b3c-39eadfcb4687)

> **Fade** 효과를 사용하고자 **OVR Intergration** 안에 있는 기능을 적용할 생각이었으나 
> 
> **OVR Intergration** 과 **XR Interaction Toolkit** 의 호환이 안되는걸 발견하여 **Fade 효과를** 사용할 수 있게 자체적으로 제작하였습니다.

---
### **2. Scene Switcher**

> SceneNaem의 값에 따라 이동할수 있는 씬을 다르게 제작하엿습니다.

---
### **3. Tag Plus**

> 사용자는 **4개의 오브젝트**중 **하나**를 선택하여 **한 가지의 엔딩**을
> 
> 볼 수 있는 로직을 구현하기 위하여 **Player** 오브젝트의 자식 오브젝트인 **Item** 오브젝트의 **"Tag"** 를
> 
> 바꿔 **엔딩**을 볼 수 있게 제작하였습니다.

---

### **4. ObjectEnding**

```csharp
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Window")) 
        {
                Debug.Log("아이템이 있으십니다 이동하겠습니다.");

                SceneManager.LoadScene(Window_Ending);
        }
        else if (other.gameObject.CompareTag("Cat"))
        {
            Debug.Log("아이템이 있으십니다 이동하겠습니다.");

            SceneManager.LoadScene(Cat_Ending);
        }
        else if (other.gameObject.CompareTag("Apple"))
        {
            Debug.Log("아이템이 있으십니다 이동하겠습니다.");

            SceneManager.LoadScene(Apple_Ending);
        }
        else if (other.gameObject.CompareTag("Bread"))
        {
            Debug.Log("아이템이 있으십니다 이동하겠습니다.");

            SceneManager.LoadScene(Bread_Ending);
        }
        else if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("키가 없어서 다음 씬으로 이동할 수 없습니다.");
        }
    }
    
}

```

> **Tag Plus** 스크립트와 같이 사용되는 스크립트이며
**지정된 태그**와 알맞은 **Scene** 으로 이동할 수 있게 제작 하였습니다.
> 

---
### **5. SetActive**

> 사용자는 게임을 클리어한 뒤 **네 가지 오브젝트**를 인벤토리에 넣고 꺼낼 수 있게 기획하였으나
> 
> 당시에 인벤토리 로직을 제작하는 과정이 다소 복잡하여 게임을 성공적으로 마친 후
> 
> 엔딩을 감상하기 직전의 마지막 단계에서 **네 개의 오브젝트** 중에서 **하나의 오브젝트**를 선택하여
> 
> 그 선택에 따라 다양한 엔딩을 경험할 수 있게 만들었습니다. 

