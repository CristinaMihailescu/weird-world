using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour {
    public PlayerWeaponController playerWeaponController;
    public Item axe;

    void Start()
    {
        playerWeaponController = GetComponent<PlayerWeaponController>();
        List<BaseStat> axeStats = new List<BaseStat>();
        axeStats.Add(new BaseStat(30, "Strength", "Your power level."));
        axe = new Item(axeStats, "Axe");
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            playerWeaponController.EquipWeapon(axe);
        }
    }
}
