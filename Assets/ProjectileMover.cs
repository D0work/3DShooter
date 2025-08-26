using UnityEngine;

public class ProjectileMover : MonoBehaviour
{
    private Vector3 targetDirection;
    private float moveSpeed;

    public void Init(Vector3 targetPosition, float speed)
    {
        targetDirection = (targetPosition - transform.position).normalized;
        moveSpeed = speed;
    }

    void Update()
    {
        transform.position += targetDirection * moveSpeed * Time.deltaTime;
    }
}
