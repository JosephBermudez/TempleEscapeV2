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
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    #region Static Variables



    #endregion

    #region Public Variables

    public string level;

    #endregion

    #region Private Variables

    private Timer timeScore;

    #endregion

    #region MonoBehaviour Callbacks
    private void Start()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (level == "Ending")
            {
                SceneManager.LoadScene("Ending");
                Debug.Log("It is the final level");
                //timeScore.GetScore();
            }
            else
            {
                Debug.Log("Player touched the gate");
                SceneManager.LoadScene(level);
            }
            //Scene currentScene = SceneManager.GetActiveScene();

            //string sceneName = currentScene.name;
            //switch (sceneName)
            //{
            //    case "Level 2":
            //        SceneManager.LoadScene("Level 3");
            //        Debug.Log("Player should've go level 3");
            //        break;
            //    case "Level 3":
            //        SceneManager.LoadScene("Level 4");
            //        Debug.Log("Player should've go level 4");
            //        break;
            //    case "Level 4":
            //        SceneManager.LoadScene("Level 5");
            //        Debug.Log("Player should've go level 5");
            //        break;
            //    case "Level 5":
            //        SceneManager.LoadScene("Level 6");
            //        Debug.Log("Player should've go level 6");
            //        break;
            //    case "Level 6":
            //        SceneManager.LoadScene("Ending");
            //        Debug.Log("Player should've go level final");
            //        break;
            //    case "Ending:":
            //        Debug.Log("It is the final level");
            //        timeScore.GetScore();
            //        break;
            //    default:
            //        Debug.Log("That level doesnt exist");
            //        break;
            //}

        }
    }

    #endregion

    #region Script Methods



    #endregion

}