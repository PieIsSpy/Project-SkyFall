using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] float movementSpeed = 10f;
    [SerializeField] float jumpForce = 5f;
    [SerializeField] GameObject player;
    [SerializeField] InputActionReference move;
    
    private Rigidbody rb;
    private bool grounded;
    private Vector2 moveDirection;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void HorizontalInput()
    {
        moveDirection = move.action.ReadValue<Vector2>();
    }

    private void HorizontalMovement()
    {
        rb.linearVelocity = new Vector3(moveDirection.x * movementSpeed, moveDirection.y * movementSpeed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        HorizontalInput();
    }

    private void FixedUpdate()
    {
        HorizontalMovement();
    }

    private void OnCollisionEnter (Collision collision)
    {
        grounded = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        grounded = false;
    }
}
