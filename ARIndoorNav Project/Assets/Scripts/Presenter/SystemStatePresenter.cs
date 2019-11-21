﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
    Script to relay high-iportance messages to the user. 
    Used for when the tracking state has degenerated too much and needs the user to react
 */
public class SystemStatePresenter : MonoBehaviour
{
    public Text trackingStatusText;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SendWarningMessage(string warning)
    {

    }

    public void DisplayTrackingStatus(string trackingStatus)
    {
        trackingStatusText.text = trackingStatus;
    }
}
