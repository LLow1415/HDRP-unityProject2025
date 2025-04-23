using UnityEngine;

public class Patrolling : MonoBehaviour
{
    public Transform[] patrolPoints;
    public float speed = 3f;
    public float patrolSwitchDistance = 0.5f;

    private int currentPointIndex = 0;
    private int direction = 1;

    void Start()
    {
        if (patrolPoints.Length == 0)
        {
            Debug.LogWarning("No patrol points assigned!");
            enabled = false;
        }
    }

    public void StartPatrolling()
    {
        if (patrolPoints.Length == 0) return;

        Patrol();
    }

    private void Patrol()
    {
        Transform targetPoint = patrolPoints[currentPointIndex];
        transform.position = Vector3.MoveTowards(transform.position, targetPoint.position, speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, targetPoint.position) < patrolSwitchDistance)
        {
            if (currentPointIndex == patrolPoints.Length - 1)
            {
                direction = -1;
            }
            else if (currentPointIndex == 0)
            {
                direction = 1;
            }

            currentPointIndex += direction;
        }
    }
}