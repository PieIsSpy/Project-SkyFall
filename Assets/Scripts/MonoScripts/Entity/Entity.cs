using System;
using UnityEngine;

public class Entity : MonoBehaviour
{
    [SerializeField] int maxHealth = 100;
    [SerializeField] int baseDamage = 1;
    // [SerializeField] Weapon[] weapons;

    private int currentHealth;
    private int currentDamage;
    // private Weapon currentWeapon;
    // private Effect[] currentEffects;

    private void TakeDamage(int damage)
    {
        currentHealth = Math.Max(currentHealth - damage, 0);
    }

    private void ChangeWeapon()
    {
        
    }

    private void ApplyEffect()
    {
        
    }

    private void ResetStats()
    {
        currentHealth = maxHealth;
        currentDamage = baseDamage;
    }
}
