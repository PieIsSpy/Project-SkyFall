using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] float movementSpeed = 10f;
    [SerializeField] float jumpForce = 5f;
    [SerializeField] float gravityMultiplier = 3.0f;

    private float currentSpeed;
    private float currentJump;

    public string CurrentSpeed { set {name = value;} }
    public string CurrentJump { set {name = value;} }
    
    private Vector2 moveInput;
    private Vector3 direction;
    private CharacterController controller;

    private readonly float gravity = -9.81f;
    private float velocity;

    private void Awake()
    {
        controller = GetComponent<CharacterController>();
        ResetStats();
    }

    private void Update()
    {
        ApplyGravity();
        ApplyMovement();
    }

    public void Move(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
        direction = new Vector3(moveInput.x, 0, 0);
    }

    public void Jump(InputAction.CallbackContext context)
    {
        if (!context.started) return;
        if (!controller.isGrounded) return;

        velocity += jumpForce;
    }

    private void ApplyMovement()
    {
        controller.Move(currentSpeed * Time.deltaTime * direction);
    }

    private void ApplyGravity()
    {
        if (controller.isGrounded && velocity < 0.0f)
        {
            velocity = -1.0f;
        }
        else
        {
            velocity += gravity * gravityMultiplier * Time.deltaTime;
        }

        direction.y = velocity;
    }

    public void ResetStats()
    {
        currentSpeed = movementSpeed;
        currentJump = jumpForce;
    }
}
