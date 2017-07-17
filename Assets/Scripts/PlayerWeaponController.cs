using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeaponController : MonoBehaviour {

    public GameObject playerHand;
    public GameObject EquippedWeapon { get; set; }

    IWeapon equippedWeapon;
    CharacterStat characterStat;

    void Start()
    {
        characterStat = GetComponent<CharacterStat>();
    }

    public void EquipWeapon(Item itemToEquip)
    {
        if(EquippedWeapon != null)
        {
            characterStat.RemoveStatBonus(EquippedWeapon.GetComponent<IWeapon>().Stats);
            Destroy(playerHand.transform.GetChild(0).gameObject);
        }

        EquippedWeapon = (GameObject)Instantiate(Resources.Load<GameObject>("Weapons/" + itemToEquip.ObjectName),
            playerHand.transform.position, playerHand.transform.rotation);

        equippedWeapon = EquippedWeapon.GetComponent<IWeapon>();

        equippedWeapon.Stats = itemToEquip.Stats;
        EquippedWeapon.transform.SetParent(playerHand.transform);

        //add weap stats to character
        characterStat.AddStatBonus(itemToEquip.Stats);

        //check
        foreach(BaseStat bs in characterStat.stats)
        {
            Debug.Log(bs.GetCalculatedStatValue());
        }
    }

    public void PerformWeaponAttack()
    {
        equippedWeapon.PerformAttack();
    }
}
