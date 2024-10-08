using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectEnding : MonoBehaviour
{
    public string Window_Ending; // "Item" �±� �������� �浹�� ��� �̵��� �� �̸�
    public string Cat_Ending; // "Item2" �±� �������� �浹�� ��� �̵��� �� �̸�
    public string Apple_Ending; // "Item3" �±� �������� �浹�� ��� �̵��� �� �̸�
    public string Bread_Ending; // "Item4" �±� �������� �浹�� ��� �̵��� �� �̸�

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Window")) // �浹�� ������Ʈ�� "Player" �±׸� ������ �ִٸ�
        {
                Debug.Log("�������� �����ʴϴ� �̵��ϰڽ��ϴ�.");

                // Ű ������Ʈ�� �ִ� ���, ���� ������ ��ȯ
                SceneManager.LoadScene(Window_Ending);
        }
        else if (other.gameObject.CompareTag("Cat"))
        {
            Debug.Log("�������� �����ʴϴ� �̵��ϰڽ��ϴ�.");

            // Ű ������Ʈ�� �ִ� ���, ���� ������ ��ȯ
            SceneManager.LoadScene(Cat_Ending);
        }
        else if (other.gameObject.CompareTag("Apple"))
        {
            Debug.Log("�������� �����ʴϴ� �̵��ϰڽ��ϴ�.");

            // Ű ������Ʈ�� �ִ� ���, ���� ������ ��ȯ
            SceneManager.LoadScene(Apple_Ending);
        }
        else if (other.gameObject.CompareTag("Bread"))
        {
            Debug.Log("�������� �����ʴϴ� �̵��ϰڽ��ϴ�.");

            // Ű ������Ʈ�� �ִ� ���, ���� ������ ��ȯ
            SceneManager.LoadScene(Bread_Ending);
        }
        else if(other.gameObject.CompareTag("Player"))
        {
            // Ű ������Ʈ�� ���� ���, �޽��� ��� �Ǵ� �ٸ� ó��
            Debug.Log("Ű�� ��� ���� ������ �̵��� �� �����ϴ�.");
        }
    }
    
}


