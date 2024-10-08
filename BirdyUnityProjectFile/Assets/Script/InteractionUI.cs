/*using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class InteractionUI : MonoBehaviour
{
    [SerializeField] private GameObject uiObject = null;
    [SerializeField] private XRController controller = null;

    private void OnEnable()
    {
        controller.selectEntered.AddListener(OnSelectEntered);
    }

    private void OnDisable()
    {
        controller.selectEntered.RemoveListener(OnSelectEntered);
    }

    private void OnSelectEntered(XRBaseInteractable interactable)
    {
        if (interactable.gameObject == this.gameObject)
        {
            uiObject.SetActive(false);
        }
    }
}
*/