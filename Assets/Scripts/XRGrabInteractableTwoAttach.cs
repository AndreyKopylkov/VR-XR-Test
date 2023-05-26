using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class XRGrabInteractableTwoAttach : XRGrabInteractable
{
    [SerializeField] private Transform _leftAttachTransform;
    [SerializeField] private Transform _rightAttachTransform;
    
    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        if (args.interactableObject.transform.CompareTag("LeftHand"))
        {
            attachTransform = _leftAttachTransform;
        }
        else if (args.interactableObject.transform.CompareTag("RightHand"))
        {
            attachTransform = _rightAttachTransform;
        }
        
        base.OnSelectEntered(args);
    }
}