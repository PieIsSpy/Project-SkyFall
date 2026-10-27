using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 5f;
    [SerializeField] private float jumpForce = 4f;

    private CharacterController characterController;

    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }

    public void Jump()
    {
        
    }

    public void Left()
    {
        
    }

    public void Right()
    {
        
    }

    public void Crouch()
    {
        
    }
}
