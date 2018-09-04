using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//******************************
//
//  Created by: Daniel Marton
//
//  Last edited by: Daniel Marton
//  Last edited on: 2/9/2018
//
//******************************

public class UI_WaveNotification : MonoBehaviour {

    //******************************************************************************************************************************
    //
    //      INSPECTOR
    //
    //******************************************************************************************************************************

    [Space]
    [Header("-----------------------------------")]
    [Header(" COMPONENTS")]
    [Space]
    public Text WaveNameTitle = null;
    public Text WaveNameDescription = null;
    public float TimeOnScreen = 3f;

    //******************************************************************************************************************************
    //
    //      VARIABLES
    //
    //******************************************************************************************************************************

    private bool _OnScreen = false;
    private float _TimerOnScreen = 0f;

    public bool _BossWave { get; set; }

    //******************************************************************************************************************************
    //
    //      FUNCTIONS
    //
    //******************************************************************************************************************************

    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    /// <summary>
    //  Called each frame.
    /// </summary>
    private void Update() {

        if (_OnScreen) {

            // Add to timer
            _TimerOnScreen += Time.deltaTime;
            if (_TimerOnScreen >= TimeOnScreen) {

                // Hide widget
                gameObject.SetActive(false);
                _OnScreen = false;
                _TimerOnScreen = 0f;
            }
        }
    }

    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    /// <summary>
    //  
    /// </summary>
    public void NewWaveNotification(WaveManager.WaveInfo waveInfo) {

        if (WaveNameDescription != null) {

            // Next wave is a boss wave - only show title text
            if (_BossWave) {

                WaveNameTitle.text = "BOSS WAVE";
                _TimerOnScreen = 0f;
                _OnScreen = true;
                gameObject.SetActive(true);
                WaveNameDescription.enabled = false;
            }

            // Not a boss wave
            else {

                WaveNameTitle.text = "NEW WAVE";
                WaveNameDescription.text = waveInfo.Name;
                _TimerOnScreen = 0f;
                _OnScreen = true;
                gameObject.SetActive(true);
                WaveNameDescription.enabled = true;
            }
        }
    }

    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////

}
