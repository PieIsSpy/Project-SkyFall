using System;
using UnityEngine;

public class Entity : MonoBehaviour
{
    [SerializeField] int maxHealth = 100;
    [SerializeField] int baseDamage = 1;

    private int currentHealth;
    private int currentDamage;

    private void Awake()
    {
        ResetStats();
    }

    private void TakeDamage(int damage)
    {
        currentHealth = Math.Max(currentHealth - damage, 0);
    }

    private void ResetStats()
    {
        currentHealth = maxHealth;
        currentDamage = baseDamage;
    }
}
