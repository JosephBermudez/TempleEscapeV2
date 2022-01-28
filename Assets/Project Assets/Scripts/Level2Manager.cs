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

public class Level2Manager : MonoBehaviour
{
    #region Static Variables



    #endregion

    #region Public Variables
    public AudioSource doorSound;


    #endregion

    #region Private Variables
    [SerializeField]
    private Animator doorMotion;

    [SerializeField]
    private GameObject teleportActive;
    #endregion

    #region MonoBehaviour Callbacks
    void Awake()
    {
       
    }
    void Start()
    {

        teleportActive.SetActive(false);
    }

    void Update()
    {
        GameObject fireAmount = GameObject.Find("PiedraTorchKey");
        ContactFire contactFire = fireAmount.GetComponent<ContactFire>();
        if (contactFire.firePoint == 1)
        {
            Debug.Log("Door Should be opening");
            OpenDoor();
            teleportActive.SetActive(true);
        }
        
    }

#endregion

#region Script Methods

	void OpenDoor()
    {
        Debug.Log("You should open the Door");
        doorMotion.SetBool("PlayMove", true);
    }

#endregion
    
}