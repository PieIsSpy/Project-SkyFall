using UnityEngine;

public class EntityController : MonoBehaviour
{
    [SerializeField] float movementSpeed = 7f;
    [SerializeField] float jumpForce = 4f;

    private float currentSpeed;
    private float currentJump;

    private void Awake()
    {
        ResetStats();
    }

    private void Jump()
    {
        
    }

    private void Left()
    {
        
    }

    private void Right()
    {
        
    }

    private void Crouch()
    {
        
    }

    private void ResetStats()
    {
        currentSpeed = movementSpeed;
        currentJump = jumpForce;
    }
}
