using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateHandController : MonoBehaviour
{
    public InputActionProperty PinchActionProperty;
    public InputActionProperty GripActionProperty;
    private InputAction mPinchAction;
    private InputAction mGripAction;

    private Animator mAnimator;

    private void Start()
    {
        mPinchAction = PinchActionProperty.action;
        mGripAction = GripActionProperty.action;
        mAnimator = GetComponent<Animator>();
    }

    private void Update()
    {
        float triggerValue = mPinchAction.ReadValue<float>();
        mAnimator.SetFloat("Trigger", triggerValue);

        float gripValue = mGripAction.ReadValue<float>();
        mAnimator.SetFloat("Grip", gripValue);
    }
}
