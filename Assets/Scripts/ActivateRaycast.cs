using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;


public class ActivateRaycast : MonoBehaviour
{ 
  // public GameObject leftTeleportation;
    // public GameObject rightTeleportation;
    public GameObject leftHandController;
    public GameObject rightHandController;
    public InputActionProperty leftActivate;
    public InputActionProperty rightActivate;
  //  public InputActionProperty leftCancel;
 //  public InputActionProperty rightCancel;


    // Update is called once per frame
    void Update()
    {
        leftHandController.SetActive(leftActivate.action.ReadValue<float>() > 1.1f);
        rightHandController.SetActive(rightActivate.action.ReadValue<float>() > 1.1f);
    }
}

