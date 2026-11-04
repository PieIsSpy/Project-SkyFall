using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] float movementSpeed = 10f;
    [SerializeField] float jumpForce = 5f;

    private float currentSpeed;
    private float currentJump;

    public string CurrentSpeed { set {name = value;} }
    public string CurrentJump { set {name = value;} }
    
    private Vector2 moveInput;
    private Vector3 direction;
    private CharacterController controller;

    private void Awake()
    {
        controller = GetComponent<CharacterController>();
        ResetStats();
    }

    private void Update()
    {
        controller.Move(currentSpeed * Time.deltaTime * direction);
    }

    public void Move(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
        direction = new Vector3(moveInput.x, 0, 0);
    }

    public void ResetStats()
    {
        currentSpeed = movementSpeed;
        currentJump = jumpForce;
    }
}
