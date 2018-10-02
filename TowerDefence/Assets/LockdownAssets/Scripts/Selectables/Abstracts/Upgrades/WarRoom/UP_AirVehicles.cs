﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//******************************
//
//  Created by: Daniel Marton
//
//  Last edited by: Daniel Marton
//  Last edited on: 29/8/2018
//
//******************************

public class UP_AirVehicles : Upgrade {

    //******************************************************************************************************************************
    //
    //      INSPECTOR
    //
    //******************************************************************************************************************************

    [Space]
    [Header("-----------------------------------")]
    [Header(" UPGRADE PROPERTIES ")]
    [Space]
    [Range(0f, 1f)]
    public float HealthCapMultiplier = 0.1f;
    [Range(0f, 1f)]
    public float DamageMultiplier = 0.1f;

    //******************************************************************************************************************************
    //
    //      FUNCTIONS
    //
    //******************************************************************************************************************************

    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    /// <summary>
    //  Called when the upgrading is complete and needs to be applied.
    /// </summary>
    public override void OnUpgrade() {
        base.OnUpgrade();

        Player player = GameManager.Instance.Players[0];
        UpgradeManager upgradeManager = player.GetUpgradeManager();

        upgradeManager._AirVehiclesHealthMultiplier -= HealthCapMultiplier;
        upgradeManager._AirVehiclesDamageMultiplier -= DamageMultiplier;
    }

    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////

}