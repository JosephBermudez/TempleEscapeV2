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

public class DontDestroy : MonoBehaviour
{
    private static DontDestroy _instance = null;
    public static DontDestroy Instance
    {
        get { return _instance; }
    }


    void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(gameObject);
            return;
        }

        _instance = this;

        DontDestroyOnLoad(gameObject);
    }
}