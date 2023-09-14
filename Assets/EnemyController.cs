using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float moveDistance = 20f;

    private Vector3 initialPosition;
    private Vector3 targetPosition;
    private bool movingRight = true;

    private void Start()
    {
        initialPosition = transform.position;
        targetPosition = initialPosition + Vector3.right * moveDistance;
    }

    private void Update()
    {
        float step = moveSpeed * Time.deltaTime;

        if (movingRight)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, step);

            if (transform.position == targetPosition)
            {
                movingRight = false;
            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, initialPosition, step);

            if (transform.position == initialPosition)
            {
                movingRight = true;
            }
        }
    }
}
