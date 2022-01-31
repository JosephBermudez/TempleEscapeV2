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

public class CheckCollision : MonoBehaviour
{
    #region Static Variables

    public string tag;
    public AudioSource clickSound;

    #endregion

    #region Public Variables
    public Level3Manager levelManager;


    #endregion

    #region Private Variables


    #endregion

    #region MonoBehaviour Callbacks

    void Start()
    {
        levelManager.totalValue = 0;
    }

    // Update is called once per frame
    void Update()
    {
    }

    #endregion

    #region Script Methods

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == tag)
        {
            levelManager.totalValue++;
            clickSound.PlayOneShot(clickSound.clip);
        }

        if (levelManager.totalValue == 3)
        {
            levelManager.OpenDoor();
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == tag)
        {
            levelManager.totalValue--;
        }
    }

    #endregion

}