using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashCan : MonoBehaviour
    //��ũ��Ʈ ���� :
    //�� ��ũ��Ʈ������ object1Triggered�� object2Triggered �� ���� boolean �÷��� ������ ����Ͽ�
    //Object1�� Object2�� ������ �浹ü�� �浹�Ͽ����� ���θ� �����մϴ�.
    //�浹ü�� Object1 �Ǵ� Object2�� �浹�ϸ� object1Triggered �Ǵ� object2Triggered�� true�� �����մϴ�.
    //CheckObjectsTriggered() �޼ҵ忡���� object1Triggered�� object2Triggered�� ��� true�� �����Ǿ������� Ȯ���Ͽ�,
    //�׷��ٸ� "Clear!"�� �ֿܼ� ����մϴ�.�� �޼ҵ�� OnTriggerEnter() �޼ҵ忡�� ȣ��˴ϴ�.
    //�� ��ũ��Ʈ�� ����Ͽ� ���ϴ� ��� �浹�ϸ� "Clear!"�� ��µǵ��� �� �� �ֽ��ϴ�.
{
    public GameObject DonutPrefab;
    public GameObject Object1; // ù ��° ���� ������Ʈ, �̰Ͱ� �浹 �˻縦 �� ���
    public GameObject Object2; // �� ��° ���� ������Ʈ, �̰Ͱ� �浹 �˻縦 �� ���
    public GameObject Object3; // �� ��° ���� ������Ʈ, �̰Ͱ� �浹 �˻縦 �� ���
    public GameObject UIPrefab; //Ŭ���� �� �ߴ� UI ������
    public GameObject TeleportPrefab; //Ŭ���� �� �ߴ� �ڷ���Ʈ ������
    public GameObject CorrectSoundPrefab;
    public GameObject ClearSoundPrefab;
    public GameObject AreaEffectPrefab;
    private bool object1Triggered; // Object1�� �浹ü�� �浹�Ͽ����� ���θ� �����ϴ� �÷��� ����
    private bool object2Triggered; // Object2�� �浹ü�� �浹�Ͽ����� ���θ� �����ϴ� �÷��� ����
    private bool object3Triggered; // Object3�� �浹ü�� �浹�Ͽ����� ���θ� �����ϴ� �÷��� ����
    
    

    
    private void OnTriggerEnter(Collider other)
    {
        
        
        // �浹�� ���� ������Ʈ�� Object1���� �˻�
        if (other.gameObject == Object1)
        {
            object1Triggered = true;
            Instantiate(CorrectSoundPrefab);
        }
        // �浹�� ���� ������Ʈ�� Object2���� �˻�
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
        //Object1�� Object2 �� ���� ��ü�� Ʈ���ſ� �浹�Ǿ������� �˻��ϰ�, Ʈ���� ���� �� ����� ������ �� �ֵ���
        //OnTriggerEnter�� �Է��Ͽ� boolean�� ����� �۵��ϸ� �ڵ尡 �۵��� �� �ֵ��� �Ѵ�. �ް����� ChatGpt�����.
        CheckObjectsTriggered();
    }

    private void CheckObjectsTriggered()
    {
        // Object1�� Object2 ��� �浹ü�� �浹�Ͽ��ٸ� "Clear!"�� �ֿܼ� ���
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
