using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class fadeinout : MonoBehaviour
{
	//Image를 공용변수인 fadeOutUIImage로 지정
	public Image fadeOutUIImage;
	//공용 변수 실수형인 fadeSpeed 의 값을 1f 로 지정
	public float fadeSpeed = 1f;
	//bool 형 FadeDir로 지정하여 true -> Alpha = 1  , false -> Alpha = 0 으로 지정
	bool FadeDir;

	private void Start()
	{
		//FadeDir = true 로 시작하여 알파값은 1f 이다.
		FadeDir = true;
	}

	private void Update()
	{
		//만약 마우스를 클릭하면
		if (Input.GetMouseButtonDown(0))
		{
			//FadeDir = false 로 알파값은  0 이다.
			FadeDir = false;
			//그리고 코루틴을 사용하여 페이드를 멈춘다.
			StartCoroutine(Fade(FadeDir));
		}
		//만약 마우스를 클릭하면
		if (Input.GetMouseButtonDown(1))
		{
			//FadeDir = false 로 알파값은  1f 이다.
			FadeDir = true;
			//그리고 코루틴을 사용하여 페이드를 멈춘다.
			StartCoroutine(Fade(FadeDir));
		}
	}
	//페이드인/아웃 효과를 구현하는 코루틴이며 FDir 인자를 통해 페이드인/아웃 방향을 결정합니다.
	private IEnumerator Fade(bool FDir)
	{
		//변수를 초기화 하여 FDir가 참이면 1 = true 로 반환 거짓이면 0 = false으로 반환 한다. 
		float alpha = (FDir) ? 1 : 0;
		//변수를 초기화 하여 FDir가 참이면 0 = true 로 반환 거짓이면 1 = false으로 반환 한다.
		float fadeEndValue = (FDir) ? 0 : 1;
		//만약 FDir가 참이면
		if (FDir)
		{
			//while반복문으로  alpha가 fadeEndValue보다 작거나 같다면
			while (alpha >= fadeEndValue)
			{
				//SetColorImage을 호출하고 alpha값과 FDir의 값을 받아온다.
				SetColorImage(ref alpha, FDir);
				//코루틴을 통해 다음 프레임까지 기대한다.
				yield return null;
			}
			//페이드아웃 효과가 끝나면 이미지를 비활성화
			fadeOutUIImage.enabled = false;
		}
		//FDir가 참이 아니라면
		else
		{
			//페이드 인 효과를 실행한다.
			fadeOutUIImage.enabled = true;
			//while 반복문을 통해 alpha가 fadeEndValue보다 크거나 같다면
			while (alpha <= fadeEndValue)
			{
				//SetColorImage을 호출하고 alpha값과 FDir의 값을 받아온다.
				SetColorImage(ref alpha, FDir);
				//코루틴을 통해 다음 프레임까지 기대한다.
				yield return null;
			}
		}
	}
	//멤버변수 SetColorImage alpha값을 이용하여 페이드인/아웃 효과를 적용 alpha값과 FDir의 값을 받아온다.
	private void SetColorImage(ref float alpha, bool FDir)
	{
		//fadeOutUIImage의 컬러는  fadeOutUIImage의 레드,그린,블루 알파값이다.
		fadeOutUIImage.color = new Color(fadeOutUIImage.color.r, fadeOutUIImage.color.g, fadeOutUIImage.color.b, alpha);
		//alpha 는 deltaTime에 1.0f 에 fadeSpeed를 나눈 값과 FDir의 값이 -1 이면 참 1이면 트루 의 값을 곱한값이다.
		alpha += Time.deltaTime * (1.0f / fadeSpeed) * ((FDir) ? -1 : 1);
	}
}