using UnityEngine;
using static UnityEngine.Rendering.DebugUI.Table;
using UnityEngine.Rendering;

public class Patrolling : MonoBehaviour
{
    public Transform pointA; // First patrol point
    public Transform pointB; // Second patrol point
    public float speed = 3f; // Patrol speed
    public float patrolSwitchDistance = 0.5f; // Distance at which to switch patrol points

    private Transform currentTarget; // Stores the current patrol target

    void Start()
    {
        currentTarget = pointA; // Start at Point A
    }

    public void StartPatrolling()
    {
        Patrol();
    }

    private void Patrol()
    {
        // Move toward the current target
        transform.position = Vector3.MoveTowards(transform.position, currentTarget.position, speed * Time.deltaTime);

        // Check if close enough to switch to the next target
        if (Vector3.Distance(transform.position, currentTarget.position) < patrolSwitchDistance)
        {
            currentTarget = (currentTarget == pointA) ? pointB : pointA;
        }
    }
}