using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Vector2 moveInput;
    private Rigidbody2D rb;
    public float moveSpeed = 1f;

    private NewControls controls;
    private Collider2D playerCollider; // Reference to the player's Collider2D.

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        controls = new NewControls();

        // Get the Collider2D component attached to the player.
        playerCollider = GetComponent<Collider2D>();

        // Enable collision detection with maze boundaries.
        rb.collisionDetectionMode = CollisionDetectionMode2D.Continuous;
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
        Vector2 targetPosition = rb.position + moveVelocity * Time.fixedDeltaTime;

        // Calculate the bounds of the player's Collider2D.
        Bounds playerBounds = playerCollider.bounds;

        // Cast a box in the direction of movement to check for collisions.
        RaycastHit2D hit = Physics2D.BoxCast(playerBounds.center, playerBounds.size, 0f, moveVelocity.normalized, moveVelocity.magnitude * Time.fixedDeltaTime);

        if (hit.collider == null || !hit.collider.CompareTag("Maze"))
        {
            rb.velocity = moveVelocity;
            rb.MovePosition(targetPosition);
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
    }
}
