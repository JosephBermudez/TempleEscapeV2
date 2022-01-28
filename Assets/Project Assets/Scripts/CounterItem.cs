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

public class CounterItem : MonoBehaviour
{
    #region Static Variables



    #endregion

    #region Public Variables
    public string tag;
    public AudioSource voidSound;
    public AudioSource openDoor;


    #endregion

    #region Private Variables
    [SerializeField]
    private Lv4Manager levelManager;
	

    #endregion

#region MonoBehaviour Callbacks
    void Start()
    {

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
            switch(tag)
            {
                case "containerA":
                print("Contenedor 1");
                levelManager.containerA++;
                Destroy(other.gameObject);
                voidSound.Play();
                break;

                case "containerB":
                print("Contenedor 2");
                levelManager.containerB++;
                voidSound.Play();
                Destroy(other.gameObject);
                break;

                case "containerC":
                print("Contenedor 3");
                levelManager.containerC++;
                voidSound.Play();
                Destroy(other.gameObject);
                break;
            }
            
        }
        if (levelManager.containerA == 4 && levelManager.containerB == 3 && levelManager.containerC == 2)
            {
                Debug.Log("Audio deberia reproducirse");
                openDoor.PlayOneShot(openDoor.clip);
                levelManager.OpenDoor();
                levelManager.teleportActive.SetActive(true);
                
            }   
    }


    #endregion

}