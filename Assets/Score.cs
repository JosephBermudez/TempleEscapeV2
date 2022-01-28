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

public class Score : MonoBehaviour
{
    #region Static Variables



    #endregion

    #region Public Variables



    #endregion

    #region Private Variables
    [SerializeField]
    private float maxScore = 100000;
    private float minuteScore = 100f;
    private float elapsed;
    private float timerSpeed = 1f;
	

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
        elapsed += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.W))
        {
            GetScore();
        }
    }

#endregion

#region Script Methods

	public void GetScore()
    {
        float playerScore = elapsed * minuteScore;
        float totalScore = maxScore - playerScore;
        Debug.Log(elapsed);
        Debug.Log(totalScore);
    }

#endregion
    
}