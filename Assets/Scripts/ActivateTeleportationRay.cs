using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class ActivateTeleportationRay : MonoBehaviour
{
    [SerializeField] private XRInteractorLineVisual _xrInteractorLineVisual;
    [SerializeField] private InputActionProperty _activateInput;
    [SerializeField] private InputActionProperty _cancel;

    private void Update()
    {
        _xrInteractorLineVisual.enabled = _cancel.action.ReadValue<float>() == 0
                                          && _activateInput.action.ReadValue<float>() > 0.1f;
    }
}