using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class OffsetGrabInteractable : XRGrabInteractable
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject attach = new GameObject("Attach");
        attach.transform.parent = transform;
        attachTransform = transform;
    }

    protected override void OnSelectEntering(XRBaseInteractor interactor)
    {
        attachTransform.position = interactor.transform.position;
        attachTransform.rotation = interactor.transform.rotation;

        base.OnSelectEntering(interactor);
    }
}
