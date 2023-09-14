using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Vector2 moveInput;
    private Rigidbody2D rb;
    public float moveSpeed = 1f;
    public float avoidanceForce = 5f;

    private NewControls controls;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        controls = new NewControls();
    }

    private void OnEnable()
    {
        controls.Enable();
        controls.Player.Move.performed += ctx => moveInput = ctx.ReadValue<Vector2>();
    }

    private void OnDisable()
    {
        controls.Disable();
        controls.Player.Move.performed -= ctx => moveInput = ctx.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        Vector2 moveVelocity = new Vector2(moveInput.x * moveSpeed, moveInput.y * moveSpeed);
        Vector2 totalForce = moveVelocity;

        rb.velocity = totalForce;
    }

 
}
