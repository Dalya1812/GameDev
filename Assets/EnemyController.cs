using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float moveDistance = 5f; 
    
    private Vector3 initialPosition;
    private int moveDirection = 1;

    private void Start()
    {
        initialPosition = transform.position;
        StartCoroutine(MoveBackAndForth());
    }

    private IEnumerator MoveBackAndForth()
    {
        while (true)
        {
            transform.Translate(Vector3.right * moveSpeed * moveDirection * Time.deltaTime);

            if (Mathf.Abs(transform.position.x - initialPosition.x) >= moveDistance)
            {
                moveDirection *= -1;

                yield return new WaitForSeconds(0.5f); 
            }

            yield return null;
        }
    }
}
