using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class XRGrabInteractableTwoAttach : XRGrabInteractable
{
    [SerializeField] private Transform _leftAttachTransform;
    [SerializeField] private Transform _rightAttachTransform;
    
    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        if (args.interactorObject.transform.CompareTag("LeftHand"))
        {
            attachTransform = _leftAttachTransform;
            Debug.Log("Left hand grab");
        }
        else if (args.interactorObject.transform.CompareTag("RightHand"))
        {
            attachTransform = _rightAttachTransform;
            Debug.Log("Right hand grab");
        }
        
        base.OnSelectEntered(args);
    }
}