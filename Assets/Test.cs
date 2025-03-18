using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class Test : MonoBehaviour
{
    public InputDevice rightHandDevice;

    // Start is called before the first frame update
    void Start()
    {
        rightHandDevice = InputDevices.GetDeviceAtXRNode(XRNode.RightHand);
    }

    // Update is called once per frame
    void Update()
    {
        if (!rightHandDevice.isValid)
        {
            rightHandDevice = InputDevices.GetDeviceAtXRNode(XRNode.RightHand);
            Debug.Log("无效");
        }
        else
        {
            Debug.Log("有效");
        }
        
        if(rightHandDevice.TryGetFeatureValue(CommonUsages.primaryButton, out bool primaryBtn) && primaryBtn)
        {
            Debug.Log("primaryBtn 按下");
        }

        if (rightHandDevice.TryGetFeatureValue(CommonUsages.secondaryButton, out bool secondBtn) && secondBtn)
        {
            Debug.Log("secondBtn 按下");
        }

        if(rightHandDevice.TryGetFeatureValue(CommonUsages.triggerButton, out bool triggerBtn) && triggerBtn)
        {
            Debug.Log("triggerBtn 按下");
        }

        if(rightHandDevice.TryGetFeatureValue(CommonUsages.gripButton, out bool gripBtn) && gripBtn)
        {
            Debug.Log("gripBtn 按下");
        }
    }
}
