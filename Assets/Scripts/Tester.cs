using System;
using System.Collections;
using System.Collections.Generic;
using Turrets;
using UnityEngine;

public class Tester : MonoBehaviour
{
    [SerializeField] private BaseTurret baseTurret = null;

    private void Start()
    {
        Debug.Log((baseTurret.damage * baseTurret.rateOfFire)/60);
    }
}
