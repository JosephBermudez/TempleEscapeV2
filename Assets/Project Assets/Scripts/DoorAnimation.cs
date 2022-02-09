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

public class DoorAnimation : MonoBehaviour
{
    #region Static Variables



    #endregion

    #region Public Variables

    public AudioSource doorOpen;

    #endregion

    #region Private Variables

    [SerializeField]
    private Animator doorMotion;

    [SerializeField]
    private GameObject teleportOption;

    #endregion

#region MonoBehaviour Callbacks
	// Awake is called when the script instance is being loaded
    void Awake()
    {
       
    }
	// Start is called before the first frame update
    void Start()
    {
        teleportOption.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    #endregion

    #region Script Methods
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Key")
        {
            Debug.Log("Door should open");
            doorMotion.SetBool("LevelComplete", true);
            teleportOption.SetActive(true);
            doorOpen.Play();
        }
        
    }
    #endregion

}