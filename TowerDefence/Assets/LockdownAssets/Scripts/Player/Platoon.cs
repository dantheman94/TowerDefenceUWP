﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//******************************
//
//  Created by: Daniel Marton
//
//  Last edited by: Daniel Marton
//  Last edited on: 27/7/2018
//
//******************************

public class Platoon : MonoBehaviour {
    
    //******************************************************************************************************************************
    //
    //      VARIABLES
    //
    //******************************************************************************************************************************

    private List<Unit> _PlatoonAi;

    //******************************************************************************************************************************
    //
    //      FUNCTIONS
    //
    //******************************************************************************************************************************

    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    /// <summary>
    //  Called when the object is created.
    /// </summary>
    private void Start() {

        _PlatoonAi = new List<Unit>();
    }
    
    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    public List<Unit> GetAi() { return _PlatoonAi; }

    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////

}