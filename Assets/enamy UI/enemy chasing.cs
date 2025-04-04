using UnityEngine;

public class enemychasing : MonoBehaviour
{
    public Transform target; // The player
    public float speed = 5f;
    public float stoppingDistance = 0.5f;
    public float activationDistance = 5f;

    public Collider safeZoneCollider; // Reference to the Safe Zone Collider

    private Patrolling patrolling; // Reference to the Patrolling script

    void Start()
    {
        patrolling = GetComponent<Patrolling>();
    }

    void Update()
    {
        // Fallback to patrolling if no target
        if (target == null)
        {
            patrolling.StartPatrolling();
            return;
        }

        // ✅ Check if the player is inside the Safe Zone (if safeZoneCollider is assigned)
        bool playerInsideSafeZone = safeZoneCollider != null && safeZoneCollider.bounds.Contains(target.position);

        // ✅ If player is NOT in Safe Zone and within chase distance, follow
        if (!playerInsideSafeZone)
        {
            float distance = Vector3.Distance(transform.position, target.position);

            if (distance <= activationDistance && distance > stoppingDistance)
            {
                FollowTarget();
                return;
            }
        }

        // ✅ Otherwise, patrol
        patrolling.StartPatrolling();
    }

    void FollowTarget()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }
}