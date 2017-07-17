using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Witch : MonoBehaviour, IEnemy {

    public int maxHealth, power, magic, armour;
    public int currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void PerformAttack()
    {
        throw new NotImplementedException();
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if(currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }

}
