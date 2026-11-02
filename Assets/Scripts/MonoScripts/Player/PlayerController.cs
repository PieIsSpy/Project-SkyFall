using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] float movementSpeed = 10f;
    [SerializeField] float jumpForce = 5f;
    [SerializeField] GameObject player;
    private Rigidbody rb;
    private bool grounded;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float x_direction = Input.GetAxisRaw("Horizontal");

        if (Mathf.Abs(rb.linearVelocity.x) < 8)
        {
            rb.linearVelocity = new Vector3(x_direction * movementSpeed, rb.linearVelocity.y, 0);
        }

        if (Input.GetButton("Jump") == true && grounded == true)
        {
            rb.AddRelativeForce(Vector3.up * jumpForce);
        }

        if (!grounded)
        {
            rb.AddRelativeForce(100 * Time.deltaTime * Vector3.down);
        }
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
