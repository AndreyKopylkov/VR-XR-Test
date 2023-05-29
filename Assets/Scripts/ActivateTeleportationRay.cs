using System;
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
        _xrInteractorLineVisual.gameObject.SetActive(_cancel.action.ReadValue<float>() == 0
                                                     && _activateInput.action.ReadValue<float>() > 0.1f);

        _xrInteractorLineVisual.transform.position = transform.position;
    }

    private void LateUpdate()
    {
        _xrInteractorLineVisual.transform.position = transform.position;
    }
}