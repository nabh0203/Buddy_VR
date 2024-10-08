using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class fadeinout : MonoBehaviour
{
	//Image�� ���뺯���� fadeOutUIImage�� ����
	public Image fadeOutUIImage;
	//���� ���� �Ǽ����� fadeSpeed �� ���� 1f �� ����
	public float fadeSpeed = 1f;
	//bool �� FadeDir�� �����Ͽ� true -> Alpha = 1  , false -> Alpha = 0 ���� ����
	bool FadeDir;

	private void Start()
	{
		//FadeDir = true �� �����Ͽ� ���İ��� 1f �̴�.
		FadeDir = true;
	}

	private void Update()
	{
		//���� ���콺�� Ŭ���ϸ�
		if (Input.GetMouseButtonDown(0))
		{
			//FadeDir = false �� ���İ���  0 �̴�.
			FadeDir = false;
			//�׸��� �ڷ�ƾ�� ����Ͽ� ���̵带 �����.
			StartCoroutine(Fade(FadeDir));
		}
		//���� ���콺�� Ŭ���ϸ�
		if (Input.GetMouseButtonDown(1))
		{
			//FadeDir = false �� ���İ���  1f �̴�.
			FadeDir = true;
			//�׸��� �ڷ�ƾ�� ����Ͽ� ���̵带 �����.
			StartCoroutine(Fade(FadeDir));
		}
	}
	//���̵���/�ƿ� ȿ���� �����ϴ� �ڷ�ƾ�̸� FDir ���ڸ� ���� ���̵���/�ƿ� ������ �����մϴ�.
	private IEnumerator Fade(bool FDir)
	{
		//������ �ʱ�ȭ �Ͽ� FDir�� ���̸� 1 = true �� ��ȯ �����̸� 0 = false���� ��ȯ �Ѵ�. 
		float alpha = (FDir) ? 1 : 0;
		//������ �ʱ�ȭ �Ͽ� FDir�� ���̸� 0 = true �� ��ȯ �����̸� 1 = false���� ��ȯ �Ѵ�.
		float fadeEndValue = (FDir) ? 0 : 1;
		//���� FDir�� ���̸�
		if (FDir)
		{
			//while�ݺ�������  alpha�� fadeEndValue���� �۰ų� ���ٸ�
			while (alpha >= fadeEndValue)
			{
				//SetColorImage�� ȣ���ϰ� alpha���� FDir�� ���� �޾ƿ´�.
				SetColorImage(ref alpha, FDir);
				//�ڷ�ƾ�� ���� ���� �����ӱ��� ����Ѵ�.
				yield return null;
			}
			//���̵�ƿ� ȿ���� ������ �̹����� ��Ȱ��ȭ
			fadeOutUIImage.enabled = false;
		}
		//FDir�� ���� �ƴ϶��
		else
		{
			//���̵� �� ȿ���� �����Ѵ�.
			fadeOutUIImage.enabled = true;
			//while �ݺ����� ���� alpha�� fadeEndValue���� ũ�ų� ���ٸ�
			while (alpha <= fadeEndValue)
			{
				//SetColorImage�� ȣ���ϰ� alpha���� FDir�� ���� �޾ƿ´�.
				SetColorImage(ref alpha, FDir);
				//�ڷ�ƾ�� ���� ���� �����ӱ��� ����Ѵ�.
				yield return null;
			}
		}
	}
	//������� SetColorImage alpha���� �̿��Ͽ� ���̵���/�ƿ� ȿ���� ���� alpha���� FDir�� ���� �޾ƿ´�.
	private void SetColorImage(ref float alpha, bool FDir)
	{
		//fadeOutUIImage�� �÷���  fadeOutUIImage�� ����,�׸�,��� ���İ��̴�.
		fadeOutUIImage.color = new Color(fadeOutUIImage.color.r, fadeOutUIImage.color.g, fadeOutUIImage.color.b, alpha);
		//alpha �� deltaTime�� 1.0f �� fadeSpeed�� ���� ���� FDir�� ���� -1 �̸� �� 1�̸� Ʈ�� �� ���� ���Ѱ��̴�.
		alpha += Time.deltaTime * (1.0f / fadeSpeed) * ((FDir) ? -1 : 1);
	}
}