using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int Health = 100;
    [SerializeField] private int Mana = 200;
    [SerializeField] private int ManaRegenDelay = 5;
    [SerializeField] private float ManaRegenRate = 1.5f;
    [SerializeField] private float MovementSpeed = 5f;
    [SerializeField] private float JumpForce = 4f;
}
