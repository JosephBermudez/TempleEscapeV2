// Copyright(C) Fyware SC - All Rights Reserved
// Unauthorized copying of this project or any file, via any medium is strictly prohibited
// Proprietary and confidential.
// If you gain access to this project or any file and you are not the recipient, 
// it is hereby notified that, in the event of any disclosure, reproduction, 
// distribution or any action in relation to the content of this project, it is strictly prohibited and could be illegal. 
// If you have received this in error, please notify us immediately by replying to contact@fyware.com and then delete it from your system.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class TeleportController : MonoBehaviour
{
    #region Static Variables



    #endregion

    #region Public Variables

    public XRController leftController;
    public XRController rightController;
    public InputHelpers.Button teleportRayButton;

    public float activationThreshhold = 0.1f;

    #endregion

    #region Private Variables

    private XRInteractorLineVisual leftRay;
    private GameObject leftReticle;

    private XRInteractorLineVisual rightRay;
    private GameObject rightReticle;

    #endregion

    #region MonoBehaviour Callbacks
    // Awake is called when the script instance is being loaded
    void Awake()
    {
       
    }
	// Start is called before the first frame update
    void Start()
    {
        leftRay = leftController.gameObject.GetComponent<XRInteractorLineVisual>();
        rightRay = rightController.gameObject.GetComponent<XRInteractorLineVisual>();

        leftReticle = leftRay.reticle;
        rightReticle = rightRay.reticle;
    }

    // Update is called once per frame
    void Update()
    {
        bool leftIsPressed = CheckIfButtonDown(leftController);
        leftRay.enabled = leftIsPressed;
        leftReticle.SetActive(leftIsPressed);

        bool rightIsPressed = CheckIfButtonDown(rightController);
        rightRay.enabled = rightIsPressed;
        rightReticle.SetActive(rightIsPressed);
    }

#endregion

#region Script Methods
    public bool CheckIfButtonDown(XRController controller)
    {
        InputHelpers.IsPressed(controller.inputDevice, teleportRayButton, out bool isPressed, activationThreshhold);
        return isPressed;
        
    }
	

#endregion
    
}