using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class ActivateGrabRay : MonoBehaviour
{
    [SerializeField] private XRInteractorLineVisual _xrInteractorLineVisual;
    [SerializeField] private XRRayInteractor _xrRayInteractor;
    [SerializeField] private XRDirectInteractor _xrDirectInteractor;
    
    private void Update()
    {
        if (_xrDirectInteractor.interactablesSelected.Count == 0)
        {
            _xrRayInteractor.enabled = true;
            _xrInteractorLineVisual.enabled = true;
        }
        else
        {
            _xrRayInteractor.enabled = false;
            _xrInteractorLineVisual.enabled = false;
        }
    }
}