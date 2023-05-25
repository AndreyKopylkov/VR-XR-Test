using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateHandOnInput : MonoBehaviour
{
    [SerializeField] private InputActionProperty _pinchAnimationAction;
    [SerializeField] private InputActionProperty _gripAnimationAction;
    [SerializeField] private Animator _animator;

    private void Update()
    {
        float triggerValue = _pinchAnimationAction.action.ReadValue<float>();
        _animator.SetFloat("Trigger", triggerValue);
        
        float gripValue = _gripAnimationAction.action.ReadValue<float>();
        _animator.SetFloat("Grip", gripValue);
    }
}