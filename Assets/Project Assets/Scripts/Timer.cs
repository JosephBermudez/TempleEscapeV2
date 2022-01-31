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
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
#region Static Variables

	

#endregion

#region Public Variables

	public Text text;
    public Text scoreText;

#endregion

#region Private Variables

	private float timer = 0.0f;
    private bool isTimer = true;

    [SerializeField]
    private float maxScore = 1000000;
    private float minuteScore = 100f;

    #endregion

#region MonoBehaviour Callbacks
	// Awake is called when the script instance is being loaded
    void Awake()
    {

    }
	// Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if (isTimer)
        {
            DisplayTime();
        }

        if (maxScore < 0)
        {
            maxScore = 0;
        }
    }

#endregion

#region Script Methods

	void DisplayTime()
    {
        isTimer = false;
        int minutes = Mathf.FloorToInt(Time.realtimeSinceStartup / 60.0f);
        int seconds = Mathf.FloorToInt(Time.realtimeSinceStartup - minutes * 60);
        text.text = string.Format("{0:00} : {1:00}", minutes,seconds);

        //score.SetActive(true);
        //isTimer = false;
        float playerScore = Time.realtimeSinceStartup * minuteScore;
        float totalScore = maxScore - playerScore;
        Debug.Log(Time.realtimeSinceStartup);
        Debug.Log(totalScore);
        scoreText.text = totalScore.ToString("0#,###0");
    }

    //public void GetScore()
    //{
    //    Scene currentScene = SceneManager.GetActiveScene();

    //    string sceneName = currentScene.name;

    //    if (sceneName == "Ending")
    //    {
    //        score.SetActive(true); 
    //        isTimer = false;
    //        float playerScore = timer * minuteScore;
    //        float totalScore = maxScore - playerScore;
    //        Debug.Log(timer);
    //        Debug.Log(totalScore);
    //        scoreText.text = totalScore.ToString("00");
    //    }

    //}

    #endregion

}