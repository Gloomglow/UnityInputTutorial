using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR; 

public class VRInput : MonoBehaviour 
{
    public GameObject leftHand;
    public GameObject rightHand; 

    public void HandTracking()
    {
        leftHand.transform.position = transform.position + InputTracking.GetLocalPosition(XRNode.LeftHand);
        rightHand.transform.position = transform.position + InputTracking.GetLocalPosition(XRNode.RightHand); 

        leftHand.transform.rotation = InputTracking.GetLocalRotation(XRNode.LeftHand);
        rightHand.transform.rotation = InputTracking.GetLocalRotation(XRNode.RightHand);
    }

    public void SampleInputs()
    {
        //Button Press// 
        if(Input.GetButtonDown("X"))
        {
            Debug.Log("You pressed down on X"); 
        }

        //Button Touch// 
        if(Input.GetButtonDown("XTouch"))
        {
            Debug.Log("Your finger touched the X button"); 
        }

        //Axis 2D// 
        Debug.Log("Left stick up-down is " + Input.GetAxis("LeftStickVertical"));
        Debug.Log("Right stick side-side is " + Input.GetAxis("LeftStickHorizontal"));

        //Axis 1D// 
        if(Input.GetAxis("LeftPalmSqueeze") > 0.1f)
        {
            Debug.Log("Palm squeeze amount is " + Input.GetAxis("LeftPalmSqueeze")); 
        }
    }

    private void Update()
    {
        HandTracking();
        SampleInputs(); 
    }


   
}
