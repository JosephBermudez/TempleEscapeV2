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

public class Lv4Manager : MonoBehaviour
{
    #region Static Variables



    #endregion

    #region Public Variables
    public int containerA,containerB,containerC;
    public GameObject teleportActive;
    public Animator doorMotion;


    #endregion

    #region Private Variables
   
    

    
    


    #endregion

    #region MonoBehaviour Callbacks
    // Awake is called when the script instance is being loaded
    void Awake()
    {
       
    }
	// Start is called before the first frame update
    void Start()
    {
        teleportActive.SetActive(false);
        ResetContainers();
    }

    // Update is called once per frame
    void Update()
    {
        /*if (containerA >= 4 && containerB >= 3 && containerC >= 2)
        {
            Debug.Log("Containers are Full");
            OpenDoor();
            teleportActive.SetActive(true);
        }*/
    }

    #endregion

    #region Script Methods

    public void OpenDoor()
    {
        Debug.Log("You should open the Door Lv 4");
        doorMotion.SetBool("PlayMove", true);
    }

    void ResetContainers()
    {
        containerA = 0;
        containerB = 0;
        containerC = 0;
    }

    #endregion

}