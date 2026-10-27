using UnityEngine;

public class PlayerVitality : MonoBehaviour
{
    [SerializeField] private int maxHealth = 100;
    [SerializeField] private int maxMana = 200;
    [SerializeField] private int manaRegenDelay = 5;
    [SerializeField] private float manaRegenRate = 1.5f;

    private int currentHealth;
    private int currentMana;
}
