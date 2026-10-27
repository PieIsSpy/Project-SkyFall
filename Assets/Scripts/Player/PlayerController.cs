using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
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
