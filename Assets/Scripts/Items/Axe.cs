using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axe : MonoBehaviour, IWeapon {

    private Animator animator;
    public List<BaseStat> Stats { get; set; }

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void PerformAttack()
    {
        animator.SetTrigger("BaseAttack");
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy")
        {
            other.GetComponent<IEnemy>().TakeDamage(gameObject.transform.parent.parent.parent
                .GetComponent<CharacterStat>().stats[2].GetCalculatedStatValue());
        }
    }
}
