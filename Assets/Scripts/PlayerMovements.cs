using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float moveSpeed = 5f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        HandleMovement();
    }

    private void HandleMovement()
    {
        float moveDirection = Input.GetAxis("Horizontal");
        float moveDirectionY = Input.GetAxis("Vertical");
        Vector2 moveVelocity = new Vector2(moveDirection * moveSpeed, moveDirectionY * moveSpeed);

        // Calculate the target position
        Vector2 targetPosition = rb.position + moveVelocity * Time.fixedDeltaTime;

        // Perform a raycast to check for obstacles before moving
        RaycastHit2D hit = Physics2D.Raycast(rb.position, moveVelocity.normalized, moveVelocity.magnitude * Time.fixedDeltaTime);
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
