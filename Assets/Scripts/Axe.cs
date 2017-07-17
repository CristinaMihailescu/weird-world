using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axe : MonoBehaviour, IWeapon {
    public List<BaseStat> Stats { get; set; }

    public void PerformAttack()
    {
        Debug.Log("Axe attack.");
    }

}
